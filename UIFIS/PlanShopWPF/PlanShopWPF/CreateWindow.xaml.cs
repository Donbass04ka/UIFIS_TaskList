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
    public partial class CreateWindow : Window
    {
        public CreateWindow()
        {
            InitializeComponent();
        }
        private void CreateBtn_Click(object sender, RoutedEventArgs e) //Создание списка
        {
            List addList = new List();
            addList = Helper.list;
            DataContext = addList;
            addList.Title = NameBox.Text; //Исправить список
            addList.IdCategory = 1;
            Helper.db.SaveChanges();
            MessageBox.Show("Список создан");
            if (Helper.userSession != null)
            {
                addList.IdUser = Helper.userSession.Id;
                Helper.db.SaveChanges();
                new Enter().Show();
                this.Close();
            }
            else
            {
                new SkipWindow().Show();
                this.Close();
            }
        }
    }
}
