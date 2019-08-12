/**
 * @author Lincoln Berlick
 * @Date 2019-08-08
 * 
 * 
 * */

using NITGEN.SDK.NBioBSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FpToExportImage
{
    class Utils
    {

        NBioAPI m_NBioAPI;

        //injeção de dependência
        public Utils(NBioAPI m_NBioAPI)
        {
            this.m_NBioAPI = m_NBioAPI;
        }



        //recebe HFIR e retorna TEXTENCODE
        public NBioAPI.Type.FIR_TEXTENCODE Fir_to_TextEncode(NBioAPI.Type.HFIR hfir)
        {
            NBioAPI.Type.FIR_TEXTENCODE txtencode = new NBioAPI.Type.FIR_TEXTENCODE();
            m_NBioAPI.GetTextFIRFromHandle(hfir, out txtencode, true);

            return txtencode;

            
        }

    


    }
}
