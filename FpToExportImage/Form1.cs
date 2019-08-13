/**
 * @author Lincoln Berlick
 * @Date 2019-07-25
 * 
 * 
 * */

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using NITGEN.SDK.NBioBSP;

namespace FpToExportImage
{
    public partial class Form1 : Form
    {

        //cria variáveis Necessárias para NBIOBSP.
        NBioAPI m_NBioAPI;
        NBioAPI.Type.WINDOW_OPTION m_WinOption;
        NBioAPI.Type.HFIR m_hNewFIR;
        NBioAPI.Export m_Export;
        NBioAPI.Type.HFIR retorno_para_exportar;
        NBioAPI.Type.FIR_TEXTENCODE m_textFIR;
        Bitmap bmp;



        public Form1()
        {


            InitializeComponent();

            //inicializa variáveis Necessárias para NBIOBSP.
            
            m_NBioAPI = new NBioAPI();
            m_WinOption = new NBioAPI.Type.WINDOW_OPTION();
            m_Export = new NBioAPI.Export(m_NBioAPI);

            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
                richTextBox1.Text = "insira o Template aqui";
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            m_WinOption.WindowStyle = NBioAPI.Type.WINDOW_STYLE.INVISIBLE;
            retorno_para_exportar = new NBioAPI.Type.HFIR();
            m_hNewFIR = new NBioAPI.Type.HFIR();
            m_NBioAPI.OpenDevice(255);
            uint ret = m_NBioAPI.Capture(NBioAPI.Type.FIR_PURPOSE.VERIFY, out m_hNewFIR, -1, retorno_para_exportar, m_WinOption);
            m_NBioAPI.GetTextFIRFromHandle(m_hNewFIR, out m_textFIR, true);
            Console.WriteLine("texto com m_new1 " + m_textFIR.TextFIR);
            m_textFIR = null;
            m_NBioAPI.GetTextFIRFromHandle(retorno_para_exportar, out m_textFIR, true);
            
            Console.WriteLine("text com retorno com retorno_para_exportar " + m_textFIR.TextFIR);
            ptb_fp.Image = Conversor(m_textFIR);


        }

        private void Btn_save_Click(object sender, EventArgs e)
        {


            SaveFileDialog salvarCaminho = new SaveFileDialog();           

            salvarCaminho.Filter = "Imagem bitmap (*.bmp)|*.bmp";
            salvarCaminho.ShowDialog();
            DialogResult dialogResult = salvarCaminho.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                bmp.Save(salvarCaminho.FileName);

            }


        }

        public Bitmap Conversor(NBioAPI.Type.HFIR Fir_toImage)
        {
            NBioAPI.Export.EXPORT_AUDIT_DATA exportData;

            m_Export.NBioBSPToImage(Fir_toImage, out exportData);
           
            int nWidth = (int)exportData.ImageWidth;
            int nHeight = (int)exportData.ImageHeight;



            {     // bmp image save...
                bmp = new Bitmap(nWidth, nHeight, PixelFormat.Format8bppIndexed);
                BitmapData data = bmp.LockBits(new Rectangle(0, 0, nWidth, nHeight), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);

                System.Runtime.InteropServices.Marshal.Copy(exportData.AuditData[0].Image[0].Data, 0, data.Scan0, nWidth * nHeight);
                bmp.UnlockBits(data);
                ColorPalette GrayscalePalette = bmp.Palette;
                for (int i = 0; i < 256; i++)
                    GrayscalePalette.Entries[i] = Color.FromArgb(i, i, i);

                bmp.Palette = GrayscalePalette;

               // bmp.Save("RollImage.bmp");

            }
          
            //Image img = bmp;
           
            return bmp;



        }
        public Bitmap Conversor(NBioAPI.Type.FIR_TEXTENCODE Fir_toImage)
        {
            NBioAPI.Export.EXPORT_AUDIT_DATA exportData;  

            m_Export.NBioBSPToImage(Fir_toImage, out exportData);

            int nWidth = (int)exportData.ImageWidth;
            int nHeight = (int)exportData.ImageHeight;            
            {     // bmp image save...
                bmp = new Bitmap(nWidth, nHeight, PixelFormat.Format8bppIndexed);
                BitmapData data = bmp.LockBits(new Rectangle(0, 0, nWidth, nHeight), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);

                System.Runtime.InteropServices.Marshal.Copy(exportData.AuditData[0].Image[0].Data, 0, data.Scan0, nWidth * nHeight);
                bmp.UnlockBits(data);
                ColorPalette GrayscalePalette = bmp.Palette;
                for (int i = 0; i < 256; i++)
                    GrayscalePalette.Entries[i] = Color.FromArgb(i, i, i);

                bmp.Palette = GrayscalePalette;

                // bmp.Save("RollImage.bmp");

            }

            //Image img = bmp;

            return bmp;



        }

        private void Ptb_fp_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
           

            String fir = richTextBox1.Text;
            //System.Windows.Forms.MessageBox.Show(fir);
          
            NBioAPI.Type.FIR_TEXTENCODE m_textFIR2 = new NBioAPI.Type.FIR_TEXTENCODE();
            m_textFIR2.TextFIR = fir;
           

            try
            {
                ptb_fp.Image = Conversor(m_textFIR2);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("não é possível converter o tamplate inserido");
            }

           
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {

            bool result;
            NBioAPI.Type.FIR_PAYLOAD myPayload = new NBioAPI.Type.FIR_PAYLOAD();
            m_NBioAPI.GetTextFIRFromHandle(m_hNewFIR, out m_textFIR, true);
            Console.WriteLine("verify " + m_textFIR.TextFIR);
            NBioAPI.Type.FIR_PURPOSE firpurpose;


           

            NBioAPI.Type.FIR_TEXTENCODE textencode = new NBioAPI.Type.FIR_TEXTENCODE();

           

            
                 bool result2;

            m_NBioAPI.GetTextFIRFromHandle(m_hNewFIR, out textencode, true);
            m_NBioAPI.VerifyMatch(textencode, textencode, out  result2, null);
            uint gui = m_NBioAPI.VerifyMatch(textencode, textencode, out result, null);
            Console.WriteLine("resultado " + result2);


            if (result)
            {
                Console.WriteLine("ok" );
            }
            else
            {
                Console.WriteLine("notok");
            }

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
