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
    /// Логика взаимодействия для ListWindow.xaml
    /// </summary>
    public partial class ListWindow : Window
    {
        public ListWindow()
        {
            InitializeComponent();
            List();
        }
        public void List() //Вывод списков в обычном без авторизации
        {
            ListGrid.ItemsSource = Helper.db.Products.Where(t => t.IdStatus == 1 || t.IdStatus == 2).ToList();
        }
        private void ExitBtn_Click(object sender, RoutedEventArgs e) //Возврат к спискам
        {
                new SkipWindow().Show();
                this.Close();
        }

        private void CreatePunctBtn_Click(object sender, RoutedEventArgs e) //Создание пункта
        {
            new CreatePunctWindow().Show();
            this.Close();
        }

        private void ListGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) //Удаление пункта
        {
            Product addProduct = new Product();
            addProduct = Helper.product;
            DataContext = addProduct;
            Helper.db.Products.Remove(addProduct);
            Helper.db.SaveChanges();
        }
    }
}
