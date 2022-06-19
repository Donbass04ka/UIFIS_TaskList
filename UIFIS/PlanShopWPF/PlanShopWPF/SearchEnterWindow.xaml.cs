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
    /// Логика взаимодействия для SearchEnterWindow.xaml
    /// </summary>
    public partial class SearchEnterWindow : Window
    {
        public SearchEnterWindow()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)  //Кнопка вернуться назад
        {
            new Enter().Show();
            this.Close();
        }
        private void ListBtn_Click(object sender, RoutedEventArgs e) //Кнопка изменить список 
        {
            new ListEnterWindow().Show();
            this.Close();
        }
    }
}
