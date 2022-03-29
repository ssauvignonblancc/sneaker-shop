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
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Window
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            deeruptSize deeruptSize = new deeruptSize();
            deeruptSize.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            nitejoggerSize nitejoggerSize = new nitejoggerSize();
            nitejoggerSize.Show();
            Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            nmdSize nmdSize = new nmdSize();
            nmdSize.Show();
            Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ozweegoSize ozweegoSize = new ozweegoSize();
            ozweegoSize.Show();
            Hide();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            boostSize boostSize = new boostSize();
            boostSize.Show();
            Hide();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            yung1Size yung1Size = new yung1Size();
            yung1Size.Show();
            Hide(); 
        }
    }
}
