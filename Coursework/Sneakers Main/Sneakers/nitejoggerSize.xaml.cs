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
using System.Windows.Shapes;

namespace Sneakers
{
    /// <summary>
    /// Логика взаимодействия для nitejoggerSize.xaml
    /// </summary>
    public partial class nitejoggerSize : Window
    {
        public nitejoggerSize()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            zakazNite zakazNite = new zakazNite();
            zakazNite.Show();
            Hide();
        }


        public static string nitSize;
        private void НайтДжогер_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                ComboBox nitSizes = (ComboBox)sender;
                TextBlock textBox = (TextBlock)НайтДжогер.SelectedItem;
                nitSize = textBox.Text.ToString();
        }
    }
}
