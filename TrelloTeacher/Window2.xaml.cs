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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        string disp;
        string teacher;
        string day_ned;
        string time;
        string grupp;
        string kab;
        string type_n;
        public Window2(string disp , string teacher , string day_ned , string time , string grupp , string kab , string type_n)
        {
            InitializeComponent();
            this.disp = disp;
            this.teacher = teacher;
            this.day_ned = day_ned;
            this.time = time;
            this.grupp = grupp;
            this.kab = kab;
            this.type_n = type_n;
        }

        private void UpdateInfo_CLick(object sender, RoutedEventArgs e)
        {
            DataBase db = new DataBase();
            db.dbConnection();
           string id = (db.SelectIdForUpdate(teacher, day_ned, disp, time, grupp, kab, type_n));

            DataBase update = new DataBase();
            update.dbConnection();
            update.UpdateCellSetka(prepodavatel.Text, days.Text, predmet.Text, times.Text, gruppa.Text, kabinet.Text, type_ned.Text, int.Parse(id));
        }

        private void Del_predmet_Click(object sender, RoutedEventArgs e)
        {
            predmet.Clear();
        }

        private void Win2_load(object sender, RoutedEventArgs e)
        {
            predmet.Text = disp;
            prepodavatel.Text = teacher;
            days.Text = day_ned;
            times.Text = time;
            gruppa.Text = grupp;
            kabinet.Text = kab;
            type_ned.Text = type_n;
        }

        private void Del_day(object sender, RoutedEventArgs e)
        {
            days.Text = "";
        }

        private void Del_gruppa(object sender, RoutedEventArgs e)
        {
            gruppa.Clear();
        }

        private void Del_time(object sender, RoutedEventArgs e)
        {
            times.Text = "";
        }

        private void Del_kab(object sender, RoutedEventArgs e)
        {
            kabinet.Clear();
        }

        private void Del_type_ned(object sender, RoutedEventArgs e)
        {
            type_ned.Text = "";
        }

        private void Del_teacher_Click(object sender, RoutedEventArgs e)
        {
            prepodavatel.Clear();
        }
    }
}
