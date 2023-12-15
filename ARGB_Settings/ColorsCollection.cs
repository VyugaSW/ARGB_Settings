using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ARGB_Settings
{
    public class ColorsCollection
    {
        public ObservableCollection<ARGBColor> Colors { get; }

        public ColorsCollection()
        {
            Colors = new ObservableCollection<ARGBColor>();
        }
        public ColorsCollection(ObservableCollection<ARGBColor> colors)
        {
            Colors = colors;
        }

        public void AddColor(Color color)
        {
            Colors.Add(new ARGBColor(color));
        }
        public void AddColor(string colorCode)
        {
            Colors.Add(new ARGBColor(colorCode));
        }

        public void DeleteColor(Color color)
        {
            Colors.Remove(Colors.FirstOrDefault(x => Color.Equals(x.PColor, color)));
        }
        public void DeleteColor(string colorCode)
        {
            Colors.Remove(Colors.FirstOrDefault(x => string.Equals(x.ColorCode, colorCode)));
        }
        public void DeleteColor(ARGBColor color)
        {
            Colors.Remove(color);
        }
    }
}
