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
using System.IO;

namespace Sneakers
{
    /// <summary>
    /// Логика взаимодействия для zakazWin.xaml
    /// </summary>
    public partial class zakazDeerupt : Window
    {
        public zakazDeerupt()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            result.Items.Add($"Логин покупателя: {AuthWindow.logins}\nМарка: Adidas Deerupt\nРазмер: { deeruptSize.derSize}\nЦена: 165$\nЦвет: Серый" );
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ваш заказ принят!");
            const string sPath = "saveDeerupt.txt";
            StreamWriter SaveFile = new StreamWriter(sPath);
            foreach (var item in result.Items)
            {
                SaveFile.WriteLine(item);
            }
            SaveFile.Close();
            Close();
        }
    }
}
