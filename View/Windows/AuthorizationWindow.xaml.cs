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

namespace Bookmaster_Tolmachev.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        string name = "1";
        string password = "1";
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UserNameTb.Text == name && PasswordPb.Password == password)
            {
                MessageBox.Show("Введено всё верно, доступ разрешен");
                BrowseCatalogWindow browseCatalog = new BrowseCatalogWindow();
                browseCatalog.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Данные не действительный, доступ воспрещен");
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            BrowseCatalogWindow browseCatalog = new BrowseCatalogWindow();
            browseCatalog.ShowDialog();
            Close();
        }

        //Метод для проверки данных пользователя
        private void Login()
        {
            if(UserNameTb.Text == "1" & PasswordPb.Password == "1")
            {
                DialogResult = true;
            }
            else
            {
                DialogResult = false;
                MessageBox.Show("Пользователь не существует!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UserNameTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
