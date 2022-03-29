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
    /// Логика взаимодействия для yung1Size.xaml
    /// </summary>
    public partial class yung1Size : Window
    {
        public yung1Size()
        {
            InitializeComponent();
        }

        public static string youngSize;
        private void Янг_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox ozwSizes = (ComboBox)sender;
            TextBlock textBox = (TextBlock)Янг.SelectedItem;
            youngSize = textBox.Text.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            zakazYung zakazYung = new zakazYung();
            zakazYung.Show();
            Hide();
        }
    }
}
