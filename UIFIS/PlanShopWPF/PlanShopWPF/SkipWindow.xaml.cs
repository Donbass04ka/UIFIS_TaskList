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
    /// Логика взаимодействия для SkipWindow.xaml
    /// </summary>
    public partial class SkipWindow : Window
    {
        public SkipWindow()
        {
            InitializeComponent();
            List();
        }
        public void List() //Вывод списков в обычном без авторизации
        {
            ListGrid.ItemsSource = Helper.db.Lists.Where(t => t.IdCategory == 1).ToList();
        }
        private void ListGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) //Открыть отдельно список для изменений и добавления элементов
        {
            List selectedList = ListGrid.SelectedItem as List;
            Helper.list = selectedList;
            new ListWindow().Show();
            this.Close();
        }
        private void Create_Click(object sender, RoutedEventArgs e) //Создать список
        {
            new CreateWindow().Show();
            this.Close();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e) //Поиск
        {
            List list = Helper.db.Lists.FirstOrDefault(q => q.Title == Search.Text);
            if (list != null)
            {
                List listSearch = Helper.db.Lists.FirstOrDefault(q => q.Id == list.Id);
                Helper.list = listSearch;
                new SearchWindow(listSearch).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Список не найден");
            }
        }
    }
}
