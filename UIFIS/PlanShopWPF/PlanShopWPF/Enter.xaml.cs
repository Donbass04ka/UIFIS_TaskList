using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;

namespace PlanShopWPF
{
    /// <summary>
    /// Логика взаимодействия для Enter.xaml
    /// </summary>
    public partial class Enter : Window
    {
        public Enter()
        {
            InitializeComponent();
            List();
        }
        public void List() //Вывод списков в обычном
        {
            ListGrid.ItemsSource = Helper.db.Lists.Where(q => q.IdUser == Helper.userSession.Id && q.IdCategory == 1).Include(t => t.IdCategoryNavigation).ToList();
        }
        private void ListGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) //Открыть отдельно список для изменений и добавления элементов
        {
            List selectedList = ListGrid.SelectedItem as List;
            Helper.list = selectedList;
            new ListEnterWindow().Show();
            this.Close();
        }
        private void SearchBtn_Click(object sender, RoutedEventArgs e) //Поиск по списку из списков
        {
            List list= Helper.db.Lists.FirstOrDefault(q => q.Title == Search.Text);
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
        private void CreateBtn_Click(object sender, RoutedEventArgs e) //Создание списка
        {
            new CreateWindow().Show();
            this.Close();
        }

        private void FavorBtn_Click(object sender, RoutedEventArgs e) //Переход к спискам из избранного
        {
            new FavoriteWindow().Show();
            this.Close();
        }
    }
}
