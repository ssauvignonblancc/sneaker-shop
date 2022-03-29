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
    /// Логика взаимодействия для deeruptSize.xaml
    /// </summary>
    public partial class deeruptSize : Window
    {
        public deeruptSize()
        {
            InitializeComponent();
        }

        public static string derSize;

        private void Дирапты_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox derSizes = (ComboBox)sender;
            TextBlock textBox = (TextBlock)Дирапты.SelectedItem;
            derSize = textBox.Text.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            zakazDeerupt zakazWin = new zakazDeerupt();
            zakazWin.Show();
            Hide();
        }
    }
}
