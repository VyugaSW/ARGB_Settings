using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ARGB_Settings
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ColorsCollection colors;

        public MainWindow()
        {
            InitializeComponent();
            colors = new ColorsCollection();
            colors.AddColor("#00FF0128");
            DataGridColors.ItemsSource = colors.Colors;
        }




        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromArgb((byte)AlphaColor.Value, (byte)RedColor.Value, (byte)GreenColor.Value, (byte)BlueColor.Value);
            ColorShowRectangle.Fill = new SolidColorBrush(color);
        }
        private void ChangeCheck(CheckBox checkBoxSender, Slider sliderSender)
        {
            if (sliderSender != null)
            {
                if ((bool)checkBoxSender.IsChecked)
                    sliderSender.IsEnabled = true;
                else
                    sliderSender.IsEnabled = false;
            }
        }
        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            Slider sliderObject = null;
            switch((sender as CheckBox).Name)
            {
                case "AlphaCheckBox":
                    sliderObject = AlphaColor;
                    break;
                case "RedCheckBox":
                    sliderObject = RedColor;
                    break;
                case "GreenCheckBox":
                    sliderObject = GreenColor;
                    break;
                case "BlueCheckBox":
                    sliderObject = BlueColor;
                    break;
            }
            ChangeCheck((sender as CheckBox), sliderObject);
        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            colors.AddColor(Color.FromArgb((byte)AlphaColor.Value, (byte)RedColor.Value, (byte)GreenColor.Value, (byte)BlueColor.Value));
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            colors.DeleteColor((sender as Button).DataContext as ARGBColor);
        }
    }
}
