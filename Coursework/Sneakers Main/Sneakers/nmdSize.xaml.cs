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
    /// Логика взаимодействия для nmdSize.xaml
    /// </summary>
    public partial class nmdSize : Window
    {
        public nmdSize()
        {
            InitializeComponent();
        }

        public static string nmddSize;
        private void НМД_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox nmdSizes = (ComboBox)sender;
            TextBlock textBox = (TextBlock)НМД.SelectedItem;
            nmddSize = textBox.Text.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            zakazNMD zakazNMD = new zakazNMD();
            zakazNMD.Show();
            Hide();
        }
    }
}
