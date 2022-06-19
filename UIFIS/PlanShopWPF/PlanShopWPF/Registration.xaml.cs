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

namespace PlanShopWPF
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text != "" && PasswordBox.Password != "" && EmailBox.Text != "")
            {
                //Регистрация выполнена успешно
                User users = new()
                {
                    Login = LoginBox.Text,
                    Password = PasswordBox.Password,
                    EMail = EmailBox.Text
                };
                Helper.db.Users.Add(users);
                Helper.db.SaveChanges();
                MessageBox.Show("Регистрация завершена");
                new Enter().Show();
                this.Close();
            }
            else MessageBox.Show("Ошибка в ведённых данных");
        }
    }
}
