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
    /// Логика взаимодействия для zakazYung.xaml
    /// </summary>
    public partial class zakazYung : Window
    {
        public zakazYung()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            result.Items.Add($"Логин покупателя: {AuthWindow.logins}\nМарка: Adidas Yung 1\nРазмер: { yung1Size.youngSize}\nЦена: 180$\nЦвет: Телесный");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
            Hide();
        }
    }
}
