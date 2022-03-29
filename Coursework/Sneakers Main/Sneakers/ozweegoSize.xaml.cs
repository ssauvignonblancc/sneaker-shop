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
    /// Логика взаимодействия для ozweegoSize.xaml
    /// </summary>
    public partial class ozweegoSize : Window
    {
        public ozweegoSize()
        {
            InitializeComponent();
        }

        public static string ozwSize;
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox ozwSizes = (ComboBox)sender;
            TextBlock textBox = (TextBlock)Озвиго.SelectedItem;
            ozwSize = textBox.Text.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            zakazozweego zakazozweego = new zakazozweego();
            zakazozweego.Show();
            Hide();
        }
    }
}
