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

namespace TrelloTeacher
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Add_days(object sender, RoutedEventArgs e)
        {
            string type = "";
            if (chetnaya.IsChecked == true)
                type = chetnaya.Content.ToString();
            if (nechetnaya.IsChecked == true)
                type = nechetnaya.Content.ToString();
            if ((string.IsNullOrWhiteSpace(teacher.Text) || string.IsNullOrWhiteSpace(task.Text) || string.IsNullOrWhiteSpace(time.Text) ||
                string.IsNullOrWhiteSpace(group.Text) || string.IsNullOrWhiteSpace(kabinet.Text)) &&
                (string.IsNullOrEmpty(teacher.Text) || string.IsNullOrEmpty(task.Text) || string.IsNullOrEmpty(time.Text) ||
                string.IsNullOrEmpty(group.Text) || string.IsNullOrEmpty(kabinet.Text)))
            {
                MessageBox.Show("Поля не заполнены!", "TrelloTeacher", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else if (chetnaya.IsChecked == false && nechetnaya.IsChecked == false)
            {
                MessageBox.Show("Не выбран тип недели!", "TrelloTeacher", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else
            {
                DataBase insert_row = new DataBase();
                insert_row.dbConnection();
                insert_row.InsertTask(teacher.Text, SwichDays.Text, task.Text, time.Text, group.Text, kabinet.Text, type);
                MessageBox.Show("Запись добавлена!", "TrelloTeacher", MessageBoxButton.OK, MessageBoxImage.Information);
                teacher.Clear();
                task.Clear();
                time.Clear();
                group.Clear();
                kabinet.Clear();

            }
        }

        private void Cheched_Chenged_Ch(object sender, RoutedEventArgs e)
        {
            if (chetnaya.IsChecked == true)
                nechetnaya.IsChecked = false;
        }

        private void Cheched_Chenged_Nch(object sender, RoutedEventArgs e)
        {
            if (nechetnaya.IsChecked == true)
                chetnaya.IsChecked = false;
        }
    }
}
