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
    public partial class SearchWindow : Window
    {
        public SearchWindow(List listSearch)
        {
            InitializeComponent();
            listSearch = Helper.list;
            DataContext = listSearch;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)  //Кнопка вернуться назад
        {
            new SkipWindow().Show();
            this.Close();
        }
        private void ListBtn_Click(object sender, RoutedEventArgs e) //Кнопка изменить список 
        {
            new ListWindow().Show();
            this.Close();
        }
    }
}
