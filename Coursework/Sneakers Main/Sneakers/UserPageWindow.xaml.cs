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
using System.Data.Entity;

namespace Sneakers
{
    /// <summary>
    /// Логика взаимодействия для UserPageWindow.xaml
    /// </summary>
    public partial class UserPageWindow : Window
    {
        ApplicationContext db;
        public UserPageWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.Users.Load();
            this.DataContext = db.Users.Local.ToBindingList();
        }

        
        // удаление
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (listOfUsers.SelectedItem == null) return;
            // получаем выделенный объект
            User user = listOfUsers.SelectedItem as User;
            db.Users.Remove(user);
            db.SaveChanges();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWin mainWin = new MainWin();
            mainWin.Show();
            Hide();
        }
    }
}
