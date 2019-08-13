/**
 * @author Lincoln Berlick
 * @Date 2019-08-08
 * 
 * 
 * */

using NITGEN.SDK.NBioBSP;
using System.Drawing;
using System.Drawing.Imaging;

namespace FpToExportImage
{
    class Utils
    {

        NBioAPI m_NBioAPI;
        NBioAPI.Export m_Export;
        Bitmap bmp;

        //injeção de dependência
        public Utils(NBioAPI m_NBioAPI)
        {
            this.m_NBioAPI = m_NBioAPI;
            m_Export = new NBioAPI.Export(m_NBioAPI);
        }



        //recebe HFIR e retorna TEXTENCODE
        public NBioAPI.Type.FIR_TEXTENCODE Fir_to_TextEncode(NBioAPI.Type.HFIR hfir)
        {
            NBioAPI.Type.FIR_TEXTENCODE txtencode = new NBioAPI.Type.FIR_TEXTENCODE();
            m_NBioAPI.GetTextFIRFromHandle(hfir, out txtencode, true);

            return txtencode;

            
        }


        //recebe HFIR retorna Bitmap
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

        //recebe TEXTENCODE retorna Bitmap
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




    }
}
