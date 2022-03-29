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
    /// Логика взаимодействия для zakazNMD.xaml
    /// </summary>
    public partial class zakazNMD : Window
    {
        public zakazNMD()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            result.Items.Add($"Логин покупателя: {AuthWindow.logins}\nМарка: Adidas Nmd r1\nРазмер: { nmdSize.nmddSize}\nЦена: 210$\nЦвет: Белый");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
            Hide();
        }
    }
}
