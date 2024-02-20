using Bookmaster_Tolmachev.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для BookAuthorDetailsWindow.xaml
    /// </summary>
    public partial class BookAuthorDetailsWindow : Window
    {
        private BookAuthor bookAuthor;

        public BookAuthorDetailsWindow()
        {
            InitializeComponent();
        }

        public BookAuthorDetailsWindow(BookAuthor bookAuthor)
        {
            this.bookAuthor = bookAuthor;

            DataContext = bookAuthor;

            AuthorsCmb.ItemsSource = App.context.BookAuthor.Where(ba => ba.Bookid == bookAuthor.Bookid).ToList();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OpenWikipediaHl_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
