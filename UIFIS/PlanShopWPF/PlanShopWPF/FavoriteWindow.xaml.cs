using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для FavoriteWindow.xaml
    /// </summary>
    public partial class FavoriteWindow : Window
    {
        public FavoriteWindow()
        {
            InitializeComponent();
        }
        public void List() //Вывод списков в избранном
        {
            ListGrid.ItemsSource = Helper.db.Lists.Where(q => q.IdUser == Helper.userSession.Id && q.IdCategory == 2).Include(t => t.IdCategoryNavigation).ToList();
        }
        private void ListBtn_Click(object sender, RoutedEventArgs e) //Вернуться к спискам
        {
            new Enter().Show();
            this.Close();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e) //Поиск
        {
            List lists = Helper.db.Lists.FirstOrDefault(q => q.Title == Search.Text);
            if (lists != null)
            {
                List listSearch = Helper.db.Lists.FirstOrDefault(q => q.Id == lists.Id);
                Helper.list = listSearch;
                new SearchWindow(listSearch).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Список не найден");
            }
        }

        private void ListGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) //Открыть список
        {
            List selectedList = ListGrid.SelectedItem as List;
            Helper.list = selectedList;
            new ListWindow().Show();
            this.Close();
        }
    }
}
