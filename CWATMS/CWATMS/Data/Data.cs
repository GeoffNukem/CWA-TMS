using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CWATMS
{
    public abstract class Data
    {
        protected String m_name;
        protected String m_label;
        protected Color m_colour;

        /// <summary>
        /// Data Constructor
        /// </summary>
        /// <param name="name">Name of data</param>
        /// <param name="label">Abbriviation of name</param>
        /// <param name="colour">Colour of data for display</param>
        public Data(String name, String label, Color colour)
        {
            m_name = name;
            m_label = label;
            m_colour = colour;
            
        }

        /// <summary>
        /// Name of data
        /// </summary>
        public String Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        /// <summary>
        /// Abbriviation of Name
        /// </summary>
        public String Label
        {
            get { return m_label; }
            set { m_label = value; }
        }

        /// <summary>
        /// Colour of data for display
        /// </summary>
        public Color Colour
        {
            get { return m_colour; }
            set { m_colour = value; }
        }

        /// <summary>
        /// Set colour of data from a string hexadecimal. EG, "RRGGBB".
        /// </summary>
        /// <param name="hexString"></param>
        public void SetColourFromHexString(String hexString)
        {
            Colour = GetColor(hexString);
        }

        private Color GetColor(string astrHexString)
        {
            string strR;
            string strG;
            string strB;
            string strRL;
            string strRR;
            string strGL;
            string strGR;
            string strBL;
            string strBR;
            int iR;
            int iG;
            int iB;
            int iRL;
            int iRR;
            int iGL;
            int iGR;
            int iBL;
            int iBR;
            Color c;
            strR = astrHexString.Substring(0, 2);
            strG = astrHexString.Substring(2, 2);
            strB = astrHexString.Substring(4, 2);
            strRL = strR.Substring(0, 1);
            strRR = strR.Substring(1, 1);
            strGL = strG.Substring(0, 1);
            strGR = strG.Substring(1, 1);
            strBL = strB.Substring(0, 1);
            strBR = strB.Substring(1, 1);
            iRL = GetIntFromHex(strRL);
            iRR = GetIntFromHex(strRR);
            iGL = GetIntFromHex(strGL);
            iGR = GetIntFromHex(strGR);
            iBL = GetIntFromHex(strBL);
            iBR = GetIntFromHex(strBR);
            iR = 16 * iRL + iRR;
            iG = 16 * iGL + iGR;
            iB = 16 * iBL + iBR;
            c = Color.FromArgb(iR, iG, iB);
            return c;
        }
        private int GetIntFromHex(string strHex)
        {
            switch (strHex)
            {
                case ("A"):
                    {
                        return 10;
                    }
                case ("B"):
                    {
                        return 11;
                    }
                case ("C"):
                    {
                        return 12;
                    }
                case ("D"):
                    {
                        return 13;
                    }
                case ("E"):
                    {
                        return 14;
                    }
                case ("F"):
                    {
                        return 15;
                    }
                default:
                    {
                        return int.Parse(strHex);
                    }
            }
        }
    }
}
