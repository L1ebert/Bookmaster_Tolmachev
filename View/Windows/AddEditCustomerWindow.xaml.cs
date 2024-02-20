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
    /// Логика взаимодействия для AddEditCustomerWindow.xaml
    /// </summary>
    public partial class AddEditCustomerWindow : Window
    {
        //Флажок, который отслеживает что нужно сделать
        //Добавить или удалить читателя
        //Добавить - false
        //Редактировать - true
        bool isEdit = false;
        public AddEditCustomerWindow()
        {
            InitializeComponent();

            isEdit = false;
        }

        public AddEditCustomerWindow(Custumer selectedCustumer)
        {
            InitializeComponent();

            DataContext = selectedCustumer;

            isEdit = true;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if(isEdit == true)
            {
                //Сохранить отредактированные изманения            
                App.context.SaveChanges();

                MessageBox.Show("Данные успешно отредактированны!");              
            }
            else
            {
                Custumer newCustumer = new Custumer
                {
                    Name = NameTb.Text,
                    Adress = AddressTb.Text,
                    Zip = ZipTb.Text,
                    City = CityTb.Text,
                    Phone = PhoneTb.Text,
                    Email = EmailTb.Text
                };

                App.context.Custumer.Add(newCustumer);
                App.context.SaveChanges();

                MessageBox.Show("Изменения успешно сохранены!");

                DialogResult = true;
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
