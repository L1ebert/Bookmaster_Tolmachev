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
    /// Логика взаимодействия для ManagerCustomerWindow.xaml
    /// </summary>
    public partial class ManagerCustomerWindow : Window
    {
        public ManagerCustomerWindow()
        {
            InitializeComponent();

            SearchResultsLv.ItemsSource = App.context.Custumer.ToList();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SearchNameTb.Text != string.Empty)
            {
                SearchResultsLv.ItemsSource = App.context.Custumer.Where(c => c.Name.Contains(SearchNameTb.Text)).ToList();
            }
        }

        private void SearchIdTb_TextChanged(object sender, TextChangedEventArgs e)
        {
          //if (SearchIdTb.Text != string.Empty)
          //{
          //}
        }

        private void SearchNameTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(SearchNameTb.Text == string.Empty)
            {
                SearchResultsLv.ItemsSource = App.context.Custumer.ToList();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SearchResultsLv.SelectedItem == null)
            {
                MessageBox.Show("Клиент не выбран!");
            }
            else
            {
                AddEditCustomerWindow addEditCustomerWindow = new AddEditCustomerWindow(SearchResultsLv.SelectedItem as Custumer);

                if (addEditCustomerWindow.ShowDialog() == true)
                {
                    SearchResultsLv.ItemsSource = App.context.Custumer.ToList();
                }
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEditCustomerWindow addEditCustomerWindow = new AddEditCustomerWindow();

            if (addEditCustomerWindow.ShowDialog() == true)
            {

            }
        }
    }
}
