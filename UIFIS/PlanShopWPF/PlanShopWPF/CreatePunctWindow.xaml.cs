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
    /// Логика взаимодействия для CreatePunctWindow.xaml
    /// </summary>
    public partial class CreatePunctWindow : Window
    {
        public CreatePunctWindow()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e) //Запись нового пункта
        {
            List addList = new List();
            Product addProduct = new Product();
            addProduct = Helper.product;
            addList = Helper.list;
            DataContext = addProduct;
            DataContext = addList;
            addProduct.Title = NameBox.Text; //Исправить добавление пунктов
            addProduct.IdStatus = 1;
            Helper.db.SaveChanges();
            MessageBox.Show("Пункт создан");
            if (addList.IdUserNavigation != null)
            {
                addList.IdUser = Helper.userSession.Id;
                Helper.db.SaveChanges();
                new ListWindow().Show();
                this.Close();
            }
            else
            {
                new ListWindow().Show();
                this.Close();
            }

        }
    }
}
