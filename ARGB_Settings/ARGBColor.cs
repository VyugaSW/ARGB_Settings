using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Globalization;

namespace ARGB_Settings
{
    public class ARGBColor
    {
        private string colorCode;
        private Color color;

        public ARGBColor(Color color)
        {
            PColor = color;
        }
        public ARGBColor(string colorCode)
        {
            ColorCode = colorCode;
        }

        public string ColorCode 
        { 
            get => colorCode;
            set
            {
                colorCode = value;
                color = FromHexToARGB(colorCode);          
            }
        }
        public Color PColor 
        {
            get => color;
            set
            {
                color = value;
                colorCode = "#" + color.A.ToString() + color.R.ToString() + color.G.ToString() + color.B.ToString();
            }
        }

        private Color FromHexToARGB(string code)
        {
            byte a = (byte)int.Parse(code.Substring(1, 2), NumberStyles.HexNumber);
            byte r = (byte)int.Parse(code.Substring(3, 2), NumberStyles.HexNumber);
            byte g = (byte)int.Parse(code.Substring(5, 2), NumberStyles.HexNumber);
            byte b = (byte)int.Parse(code.Substring(7, 2), NumberStyles.HexNumber);

            return Color.FromArgb(a,r, g, b);
        }

    }


}
