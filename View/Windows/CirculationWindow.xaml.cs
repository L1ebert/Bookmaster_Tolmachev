using Bookmaster_Tolmachev.Model;
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
    /// Логика взаимодействия для CirculationWindow.xaml
    /// </summary>
    public partial class CirculationWindow : Window
    {
        public CirculationWindow()
        {
            InitializeComponent();
        }

        private void CirculationBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(FindCustomer() != null)
                {
                    DataContext = FindCustomer();

                    EditBtn.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("Клиент с таким идентификатором не найден");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Введите корректные данные!\nИсключение: {ex.Message}");
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if(FindCustomer() != null)
            {
                AddEditCustomerWindow addEditCustomerWindow = new AddEditCustomerWindow(FindCustomer());
                addEditCustomerWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите пользователя");
            }
        }

        private Custumer FindCustomer()
        {
            //"Ричард" >> Trim ('а', 'р') >> Ричд
            //"С1028" >> Trim ('С') >> 1028
            int ID = int.Parse(CustomerIDTb.Text.Trim('C'));

            Custumer selectedCustomer = App.context.Custumer.FirstOrDefault(c => ID == c.ID);

            return selectedCustomer != null ? selectedCustomer : null;
        }

        private Book FindBook()
        {
            int bookId = int.Parse(BookIDTb.Text);
            Book selectedBook = App.context.Book.FirstOrDefault(c => bookId == c.Bookid);
            return selectedBook != null ? selectedBook : null;
        }

        private void BookIDTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                MessageBox.Show(FindBook().Title);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Книга с указанным идентификатором отсутсвует.");
            }
            catch(FormatException)
            {
                MessageBox.Show("Введите идентификатор.");
            }
        }
    }
}