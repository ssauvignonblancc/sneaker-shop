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
    /// Логика взаимодействия для zakazozweego.xaml
    /// </summary>
    public partial class zakazozweego : Window
    {
        public zakazozweego()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            result.Items.Add($"Логин покупателя: {AuthWindow.logins}\nМарка: Adidas Ozweego\nРазмер: { ozweegoSize.ozwSize}\nЦена: 210$\nЦвет: Фиолетовый");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
            Hide();
        }
    }
}
