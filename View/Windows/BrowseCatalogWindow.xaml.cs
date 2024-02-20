using Bookmaster_Tolmachev.Model;
using Bookmaster_Tolmachev.View.Pages;
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
    /// Логика взаимодействия для BrowseCatalogWindow.xaml
    /// </summary>
    public partial class BrowseCatalogWindow : Window
    {
        public BrowseCatalogWindow()
        {
            InitializeComponent();
            
            //Загрузка страницы в элемент Framе
            SearchResultsLv.ItemsSource = App.context.BookAuthor.ToList();
        }

        #region Menu actions
        private void LoginMi_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow loginWindow = new AuthorizationWindow();

            if(loginWindow.ShowDialog() == true)
            {
                LoginMi.Visibility = Visibility.Collapsed;

                LogoutMi.Visibility = Visibility.Visible;

                LibraryMi.Visibility = Visibility.Visible;
            }
        }

        private void LogoutMi_Click(object sender, RoutedEventArgs e)
        {
            LoginMi.Visibility = Visibility.Visible;

            LogoutMi.Visibility = Visibility.Collapsed;

            LibraryMi.Visibility = Visibility.Collapsed;
        }

        private void CloseMi_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); //Закрыть приложение
        }

        private void ManagerCustomersMi_Click(object sender, RoutedEventArgs e)
        {
            ManagerCustomerWindow managerCustomerWindow = new ManagerCustomerWindow();
            managerCustomerWindow.ShowDialog();
            this.Close();
        }

        private void CirculationMi_Click(object sender, RoutedEventArgs e)
        {
            CirculationWindow circulationWindow = new CirculationWindow();
            circulationWindow.ShowDialog();
        }

        private void ReportsMi_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion


        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (TitleSearchTb.Text != string.Empty)
            {
                SearchResultsLv.ItemsSource = App.context.BookAuthor.Where(ba => ba.Book.Title.Contains(TitleSearchTb.Text)).ToList();
            }
        }

        private void TitleSearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TitleSearchTb.Text == string.Empty)
            {
                SearchResultsLv.ItemsSource = App.context.BookAuthor.ToList();
            }
        }

        private void SearchResultsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Указываем вручную контекст данных
            BookDetailsGrid.DataContext = SearchResultsLv.SelectedItem as BookAuthor;
        }

        private void AuthorDetailsHl_Click(object sender, RoutedEventArgs e)
        {
            BookAuthorDetailsWindow bookAuthorDetailsWindow = new BookAuthorDetailsWindow(SearchResultsLv.SelectedItem as BookAuthor);
        }
    }
}
