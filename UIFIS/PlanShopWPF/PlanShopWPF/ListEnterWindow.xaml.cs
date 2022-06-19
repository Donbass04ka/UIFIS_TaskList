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
    /// Логика взаимодействия для ListEnterWindow.xaml
    /// </summary>
    public partial class ListEnterWindow : Window
    {
        public ListEnterWindow()
        {
            InitializeComponent();
            List();
        }

        public void List() //Вывод пунктов в обычном
        {
            ListGrid.ItemsSource = Helper.db.Products.Where(t => t.IdStatus == 1 || t.IdStatus == 2).ToList();
        }
        private void ExitBtn_Click(object sender, RoutedEventArgs e) //Вернуться к спискам
        {
                new Enter().Show();
                this.Close();
        }

        private void CreatePunctBtn_Click(object sender, RoutedEventArgs e) //Создать пункт
        {
            new CreatePunctWindow().Show();
            this.Close();
        }

        private void FavoriteBtn_Click(object sender, RoutedEventArgs e) //Открыть избранное
        {
            List addList = new List();
            addList = Helper.list;
            DataContext = addList;
            addList.IdCategory = 2;
            Helper.db.SaveChanges();
            MessageBox.Show("Список добавлен в избранное");
            new ListWindow().Show();
            this.Close();
        }

        private void ListGrid_MouseDoubleClick_1(object sender, MouseButtonEventArgs e) //Удаление пункта
        {
            Product addProduct = new Product();
            addProduct = Helper.product;
            DataContext = addProduct;
            Helper.db.Products.Remove(addProduct);
            Helper.db.SaveChanges();
        }
    }
}
