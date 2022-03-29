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
    /// Логика взаимодействия для boostSize.xaml
    /// </summary>
    public partial class boostSize : Window
    {
        public boostSize()
        {
            InitializeComponent();
        }

        public static string iziSize;
        private void Изи_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox iziSizes = (ComboBox)sender;
            TextBlock textBox = (TextBlock)Изи.SelectedItem;
            iziSize = textBox.Text.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            zakazBoost zakazBoost = new zakazBoost();
            zakazBoost.Show();
            Hide();
        }
    }
}
