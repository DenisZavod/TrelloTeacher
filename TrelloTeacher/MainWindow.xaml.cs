using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TrelloTeacher
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Setka> rw;
        public int c = 0; // 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataBase load_t = new DataBase();
            load_t.dbConnection();
            load_t.LoadTeacher(listBoxTeacher);
            load_t.LoadTeacher(listBoxTeacher_2);
            rw = new ObservableCollection<Setka>();
            for (int i = 0; i < 7; i++)

            { rw.Add(new Setka()); }

            dgw1.ItemsSource = rw;
            dgw1.Columns[0].Header = "Время";
            dgw1.Columns[1].Header = "Понедельник";
            dgw1.Columns[2].Header = "Вторник";
            dgw1.Columns[3].Header = "Среда";
            dgw1.Columns[4].Header = "Четверг";
            dgw1.Columns[5].Header = "Пятница";
            dgw1.Columns[6].Header = "Суббота";



            rw[0].Time = "8.00 - 9.35";
            rw[1].Time = "9.45 - 11.20";
            rw[2].Time = "11.50 - 13.25";
            rw[3].Time = "13.35 - 15.10";
            rw[4].Time = "15.40 - 17.15";
            rw[5].Time = "17.25 - 19.00";
            rw[6].Time = "19.10 - 20.45";

            data.Content = DateTime.Now.Date.ToShortDateString();
        }



        private void Add_Day(object sender, RoutedEventArgs e)
        {
            Window add_day = new Window1();
            add_day.ShowDialog();
        }



        private void listBoxTeacher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selected_day = Type_nedelya.Text;
            dgw1.ItemsSource = null;

            rw = new ObservableCollection<Setka>();
            for (int i = 0; i < 7; i++)

            { rw.Add(new Setka()); }

            dgw1.ItemsSource = rw;
            dgw1.Columns[0].Header = "Время";
            dgw1.Columns[1].Header = "Понедельник";
            dgw1.Columns[2].Header = "Вторник";
            dgw1.Columns[3].Header = "Среда";
            dgw1.Columns[4].Header = "Четверг";
            dgw1.Columns[5].Header = "Пятница";
            dgw1.Columns[6].Header = "Суббота";



            rw[0].Time = "8.00 - 9.35";
            rw[1].Time = "9.45 - 11.20";
            rw[2].Time = "11.50 - 13.25";
            rw[3].Time = "13.35 - 15.10";
            rw[4].Time = "15.40 - 17.15";
            rw[5].Time = "17.25 - 19.00";
            rw[6].Time = "19.10 - 20.45";

            DataBase loading_setka = new DataBase();
            loading_setka.dbConnection();
            loading_setka.LoadPredmetPn_800(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPn_945(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPn_1150(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPn_1335(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPn_1540(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPn_1725(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPn_1910(rw, listBoxTeacher, selected_day);


            loading_setka.LoadPredmetVt_800(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetVt_945(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetVt_1150(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetVt_1335(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetVt_1540(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetVt_1725(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetVt_1910(rw, listBoxTeacher, selected_day);



            loading_setka.LoadPredmetSr_800(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSr_945(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSr_1150(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSr_1335(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSr_1540(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSr_1725(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSr_1910(rw, listBoxTeacher, selected_day);



            loading_setka.LoadPredmetCht_800(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetCht_945(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetCht_1150(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetCht_1335(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetCht_1540(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetCht_1725(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetCht_1910(rw, listBoxTeacher, selected_day);



            loading_setka.LoadPredmetPt_800(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPt_945(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPt_1150(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPt_1335(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPt_1540(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPt_1725(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPt_1910(rw, listBoxTeacher, selected_day);



            loading_setka.LoadPredmetSb_800(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSb_945(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSb_1150(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSb_1335(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSb_1540(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSb_1725(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSb_1910(rw, listBoxTeacher, selected_day);
            if (Type_nedelya.Text == "Нечетная неделя")
            prepod.Content = listBoxTeacher.SelectedValue;

            if (Type_nedelya.Text == "Четная неделя")
                prepod.Content = listBoxTeacher_2.SelectedValue;

        }

        private void sel_btn(object sender, RoutedEventArgs e)
        {
            c = dgw1.CurrentCell.Column.DisplayIndex; // индекс колонки
            int r = dgw1.Items.IndexOf(dgw1.SelectedCells[0].Item); //индекс строки

            if (c == 1)
            {
                DataBase load_predmet = new DataBase();
                load_predmet.dbConnection();
                load_predmet.LoadFullInformation(prepod.Content.ToString(), rw[r].Time.ToString(), "Понедельник", rw[r].Pn.ToString(), Type_nedelya.Text, group, kabinet);
            }

            if (c == 2)
            {
                MessageBox.Show(rw[r].Vt.ToString());
            }

            if (c == 3)
            {
                MessageBox.Show(rw[r].Sr.ToString());
            }

            if (c == 4)
            {
                MessageBox.Show(rw[r].Cht.ToString());
            }

            if (c == 5)
            {
                MessageBox.Show(rw[r].Pt.ToString());
            }

            if (c == 6)
            {
                MessageBox.Show(rw[r].Sb.ToString());
            }
        }

        private void dgw1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void Info_CLick(object sender, RoutedEventArgs e)
        {
            c = dgw1.CurrentCell.Column.DisplayIndex; // индекс колонки
            int r = dgw1.Items.IndexOf(dgw1.SelectedCells[0].Item); //индекс строки
            time.Content = rw[r].Time.ToString();

            if (c == 1)
            {
                DataBase load_predmet = new DataBase();
                load_predmet.dbConnection();
                load_predmet.LoadFullInformation(prepod.Content.ToString(), rw[r].Time.ToString(), "Понедельник", rw[r].Pn.ToString(), Type_nedelya.Text, group, kabinet);
            }

            if (c == 2)
            {
                DataBase load_predmet = new DataBase();
                load_predmet.dbConnection();
                load_predmet.LoadFullInformation(prepod.Content.ToString(), rw[r].Time.ToString(), "Вторник", rw[r].Vt.ToString(), Type_nedelya.Text, group, kabinet);
            }

            if (c == 3)
            {
                DataBase load_predmet = new DataBase();
                load_predmet.dbConnection();
                load_predmet.LoadFullInformation(prepod.Content.ToString(), rw[r].Time.ToString(), "Среда", rw[r].Sr.ToString(), Type_nedelya.Text, group, kabinet);
            }

            if (c == 4)
            {
                DataBase load_predmet = new DataBase();
                load_predmet.dbConnection();
                load_predmet.LoadFullInformation(prepod.Content.ToString(), rw[r].Time.ToString(), "Четверг", rw[r].Cht.ToString(), Type_nedelya.Text, group, kabinet);
            }

            if (c == 5)
            {
                DataBase load_predmet = new DataBase();
                load_predmet.dbConnection();
                load_predmet.LoadFullInformation(prepod.Content.ToString(), rw[r].Time.ToString(), "Пятница", rw[r].Pt.ToString(), Type_nedelya.Text, group, kabinet);
            }

            if (c == 6)
            {
                DataBase load_predmet = new DataBase();
                load_predmet.dbConnection();
                load_predmet.LoadFullInformation(prepod.Content.ToString(), rw[r].Time.ToString(), "Суббота", rw[r].Sb.ToString(), Type_nedelya.Text, group, kabinet);
            }
        }


        string disp = "";
        string day = "";
       
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            c = dgw1.CurrentCell.Column.DisplayIndex; // индекс колонки
            int r = dgw1.Items.IndexOf(dgw1.SelectedCells[0].Item); //индекс строки
            string time = "";
            time = rw[r].Time.ToString();

            if (c == 1)
            {
                disp = rw[r].Pn.ToString();
                day = "Понедельник";
            }

            if (c == 2)
            {
                disp = rw[r].Vt.ToString();
                day = "Вторник";
            }

            if (c == 3)
            {
                disp = rw[r].Sr.ToString();
                day = "Среда";
            }

            if (c == 4)
            {
                disp = rw[r].Cht.ToString();
                day = "Четверг";
            }

            if (c == 5)
            {
                disp = rw[r].Pt.ToString();
                day = "Пятница";
            }

            if (c == 6)
            {
                disp = rw[r].Sb.ToString();
                day = "Суббота";
            }
            Window2 wd2 = new Window2(disp , prepod.Content.ToString() , day , time , group.Content.ToString() , kabinet.Content.ToString() , Type_nedelya.Text);
            wd2.Show();
        }

        private void Update_Teacher(object sender, RoutedEventArgs e)
        {
            listBoxTeacher.Items.Clear();
            listBoxTeacher_2.Items.Clear();
            DataBase load_t = new DataBase();
            load_t.dbConnection();
            load_t.LoadTeacher(listBoxTeacher);

            load_t.dbConnection();
            load_t.LoadTeacher(listBoxTeacher_2);


        }

        private void Update_Setka(object sender, RoutedEventArgs e)
        {
            string selected_day = Type_nedelya.Text; ;
            dgw1.ItemsSource = null;

            rw = new ObservableCollection<Setka>();
            for (int i = 0; i < 7; i++)

            { rw.Add(new Setka()); }

            dgw1.ItemsSource = rw;
            dgw1.Columns[0].Header = "Время";
            dgw1.Columns[1].Header = "Понедельник";
            dgw1.Columns[2].Header = "Вторник";
            dgw1.Columns[3].Header = "Среда";
            dgw1.Columns[4].Header = "Четверг";
            dgw1.Columns[5].Header = "Пятница";
            dgw1.Columns[6].Header = "Суббота";



            rw[0].Time = "8.00 - 9.35";
            rw[1].Time = "9.45 - 11.20";
            rw[2].Time = "11.50 - 13.25";
            rw[3].Time = "13.35 - 15.10";
            rw[4].Time = "15.40 - 17.15";
            rw[5].Time = "17.25 - 19.00";
            rw[6].Time = "19.10 - 20.45";

            DataBase loading_setka = new DataBase();
            loading_setka.dbConnection();
            loading_setka.LoadPredmetPn_800(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPn_945(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPn_1150(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPn_1335(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPn_1540(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPn_1725(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPn_1910(rw, listBoxTeacher, selected_day);


            loading_setka.LoadPredmetVt_800(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetVt_945(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetVt_1150(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetVt_1335(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetVt_1540(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetVt_1725(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetVt_1910(rw, listBoxTeacher, selected_day);



            loading_setka.LoadPredmetSr_800(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSr_945(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSr_1150(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSr_1335(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSr_1540(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSr_1725(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSr_1910(rw, listBoxTeacher, selected_day);



            loading_setka.LoadPredmetCht_800(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetCht_945(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetCht_1150(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetCht_1335(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetCht_1540(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetCht_1725(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetCht_1910(rw, listBoxTeacher, selected_day);



            loading_setka.LoadPredmetPt_800(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPt_945(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPt_1150(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPt_1335(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPt_1540(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPt_1725(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetPt_1910(rw, listBoxTeacher, selected_day);



            loading_setka.LoadPredmetSb_800(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSb_945(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSb_1150(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSb_1335(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSb_1540(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSb_1725(rw, listBoxTeacher, selected_day);
            loading_setka.LoadPredmetSb_1910(rw, listBoxTeacher, selected_day);
            prepod.Content = listBoxTeacher.SelectedValue;
        }

        private void listBoxTeacher2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selected_day = Type_nedelya.Text;
            dgw1.ItemsSource = null;

            rw = new ObservableCollection<Setka>();
            for (int i = 0; i < 7; i++)

            { rw.Add(new Setka()); }

            dgw1.ItemsSource = rw;
            dgw1.Columns[0].Header = "Время";
            dgw1.Columns[1].Header = "Понедельник";
            dgw1.Columns[2].Header = "Вторник";
            dgw1.Columns[3].Header = "Среда";
            dgw1.Columns[4].Header = "Четверг";
            dgw1.Columns[5].Header = "Пятница";
            dgw1.Columns[6].Header = "Суббота";



            rw[0].Time = "8.00 - 9.35";
            rw[1].Time = "9.45 - 11.20";
            rw[2].Time = "11.50 - 13.25";
            rw[3].Time = "13.35 - 15.10";
            rw[4].Time = "15.40 - 17.15";
            rw[5].Time = "17.25 - 19.00";
            rw[6].Time = "19.10 - 20.45";

            DataBase loading_setka = new DataBase();
            loading_setka.dbConnection();
            loading_setka.LoadPredmetPn_800(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPn_945(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPn_1150(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPn_1335(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPn_1540(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPn_1725(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPn_1910(rw, listBoxTeacher_2, selected_day);


            loading_setka.LoadPredmetVt_800(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetVt_945(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetVt_1150(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetVt_1335(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetVt_1540(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetVt_1725(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetVt_1910(rw, listBoxTeacher_2, selected_day);



            loading_setka.LoadPredmetSr_800(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSr_945(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSr_1150(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSr_1335(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSr_1540(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSr_1725(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSr_1910(rw, listBoxTeacher_2, selected_day);



            loading_setka.LoadPredmetCht_800(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetCht_945(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetCht_1150(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetCht_1335(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetCht_1540(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetCht_1725(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetCht_1910(rw, listBoxTeacher_2, selected_day);



            loading_setka.LoadPredmetPt_800(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPt_945(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPt_1150(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPt_1335(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPt_1540(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPt_1725(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPt_1910(rw, listBoxTeacher_2, selected_day);



            loading_setka.LoadPredmetSb_800(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSb_945(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSb_1150(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSb_1335(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSb_1540(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSb_1725(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSb_1910(rw, listBoxTeacher_2, selected_day);
            if (Type_nedelya.Text == "Нечетная неделя")
                prepod.Content = listBoxTeacher.SelectedValue;

            if (Type_nedelya.Text == "Четная неделя")
                prepod.Content = listBoxTeacher_2.SelectedValue;
        }

        private void Update_Setka_2(object sender, RoutedEventArgs e)
        {
            string selected_day = Type_nedelya.Text;
            dgw1.ItemsSource = null;

            rw = new ObservableCollection<Setka>();
            for (int i = 0; i < 7; i++)

            { rw.Add(new Setka()); }

            dgw1.ItemsSource = rw;
            dgw1.Columns[0].Header = "Время";
            dgw1.Columns[1].Header = "Понедельник";
            dgw1.Columns[2].Header = "Вторник";
            dgw1.Columns[3].Header = "Среда";
            dgw1.Columns[4].Header = "Четверг";
            dgw1.Columns[5].Header = "Пятница";
            dgw1.Columns[6].Header = "Суббота";



            rw[0].Time = "8.00 - 9.35";
            rw[1].Time = "9.45 - 11.20";
            rw[2].Time = "11.50 - 13.25";
            rw[3].Time = "13.35 - 15.10";
            rw[4].Time = "15.40 - 17.15";
            rw[5].Time = "17.25 - 19.00";
            rw[6].Time = "19.10 - 20.45";

            DataBase loading_setka = new DataBase();
            loading_setka.dbConnection();
            loading_setka.LoadPredmetPn_800(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPn_945(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPn_1150(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPn_1335(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPn_1540(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPn_1725(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPn_1910(rw, listBoxTeacher_2, selected_day);


            loading_setka.LoadPredmetVt_800(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetVt_945(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetVt_1150(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetVt_1335(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetVt_1540(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetVt_1725(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetVt_1910(rw, listBoxTeacher_2, selected_day);



            loading_setka.LoadPredmetSr_800(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSr_945(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSr_1150(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSr_1335(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSr_1540(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSr_1725(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSr_1910(rw, listBoxTeacher_2, selected_day);



            loading_setka.LoadPredmetCht_800(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetCht_945(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetCht_1150(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetCht_1335(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetCht_1540(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetCht_1725(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetCht_1910(rw, listBoxTeacher_2, selected_day);



            loading_setka.LoadPredmetPt_800(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPt_945(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPt_1150(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPt_1335(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPt_1540(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPt_1725(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetPt_1910(rw, listBoxTeacher_2, selected_day);



            loading_setka.LoadPredmetSb_800(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSb_945(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSb_1150(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSb_1335(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSb_1540(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSb_1725(rw, listBoxTeacher_2, selected_day);
            loading_setka.LoadPredmetSb_1910(rw, listBoxTeacher_2, selected_day);
            prepod.Content = listBoxTeacher_2.SelectedValue;
        }

        private void Del_Row(object sender, RoutedEventArgs e)
        {
            c = dgw1.CurrentCell.Column.DisplayIndex; // индекс колонки
            int r = dgw1.Items.IndexOf(dgw1.SelectedCells[0].Item); //индекс строки
            string time = "";
            time = rw[r].Time.ToString();

            if (c == 1)
            {
                disp = rw[r].Pn.ToString();
                day = "Понедельник";
            }

            if (c == 2)
            {
                disp = rw[r].Vt.ToString();
                day = "Вторник";
            }

            if (c == 3)
            {
                disp = rw[r].Sr.ToString();
                day = "Среда";
            }

            if (c == 4)
            {
                disp = rw[r].Cht.ToString();
                day = "Четверг";
            }

            if (c == 5)
            {
                disp = rw[r].Pt.ToString();
                day = "Пятница";
            }

            if (c == 6)
            {
                disp = rw[r].Sb.ToString();
                day = "Суббота";
            }

            DataBase db = new DataBase();
            db.dbConnection();
            int id = int.Parse(db.SelectIdForUpdate(prepod.Content.ToString(), day, disp, time, group.Content.ToString(), kabinet.Content.ToString(), Type_nedelya.Text));
            db.dbConnection();
            db.DeleteRowSetka(id);

            string selected_day = Type_nedelya.Text; ;
            dgw1.ItemsSource = null;

            if (selected_day == "Нечетная неделя")
            {
                rw = new ObservableCollection<Setka>();
                for (int i = 0; i < 7; i++)

                { rw.Add(new Setka()); }

                dgw1.ItemsSource = rw;
                dgw1.Columns[0].Header = "Время";
                dgw1.Columns[1].Header = "Понедельник";
                dgw1.Columns[2].Header = "Вторник";
                dgw1.Columns[3].Header = "Среда";
                dgw1.Columns[4].Header = "Четверг";
                dgw1.Columns[5].Header = "Пятница";
                dgw1.Columns[6].Header = "Суббота";



                rw[0].Time = "8.00 - 9.35";
                rw[1].Time = "9.45 - 11.20";
                rw[2].Time = "11.50 - 13.25";
                rw[3].Time = "13.35 - 15.10";
                rw[4].Time = "15.40 - 17.15";
                rw[5].Time = "17.25 - 19.00";
                rw[6].Time = "19.10 - 20.45";

                DataBase loading_setka = new DataBase();
                loading_setka.dbConnection();
                loading_setka.LoadPredmetPn_800(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetPn_945(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetPn_1150(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetPn_1335(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetPn_1540(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetPn_1725(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetPn_1910(rw, listBoxTeacher, selected_day);


                loading_setka.LoadPredmetVt_800(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetVt_945(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetVt_1150(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetVt_1335(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetVt_1540(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetVt_1725(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetVt_1910(rw, listBoxTeacher, selected_day);



                loading_setka.LoadPredmetSr_800(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetSr_945(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetSr_1150(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetSr_1335(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetSr_1540(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetSr_1725(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetSr_1910(rw, listBoxTeacher, selected_day);



                loading_setka.LoadPredmetCht_800(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetCht_945(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetCht_1150(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetCht_1335(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetCht_1540(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetCht_1725(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetCht_1910(rw, listBoxTeacher, selected_day);



                loading_setka.LoadPredmetPt_800(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetPt_945(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetPt_1150(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetPt_1335(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetPt_1540(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetPt_1725(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetPt_1910(rw, listBoxTeacher, selected_day);



                loading_setka.LoadPredmetSb_800(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetSb_945(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetSb_1150(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetSb_1335(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetSb_1540(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetSb_1725(rw, listBoxTeacher, selected_day);
                loading_setka.LoadPredmetSb_1910(rw, listBoxTeacher, selected_day);
            }

            if (selected_day == "Четная неделя")
            {           
               rw = new ObservableCollection<Setka>();
                for (int i = 0; i < 7; i++)

                { rw.Add(new Setka()); }

                dgw1.ItemsSource = rw;
                dgw1.Columns[0].Header = "Время";
                dgw1.Columns[1].Header = "Понедельник";
                dgw1.Columns[2].Header = "Вторник";
                dgw1.Columns[3].Header = "Среда";
                dgw1.Columns[4].Header = "Четверг";
                dgw1.Columns[5].Header = "Пятница";
                dgw1.Columns[6].Header = "Суббота";



                rw[0].Time = "8.00 - 9.35";
                rw[1].Time = "9.45 - 11.20";
                rw[2].Time = "11.50 - 13.25";
                rw[3].Time = "13.35 - 15.10";
                rw[4].Time = "15.40 - 17.15";
                rw[5].Time = "17.25 - 19.00";
                rw[6].Time = "19.10 - 20.45";

                DataBase loading_setka = new DataBase();
                loading_setka.dbConnection();
                loading_setka.LoadPredmetPn_800(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetPn_945(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetPn_1150(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetPn_1335(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetPn_1540(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetPn_1725(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetPn_1910(rw, listBoxTeacher_2, selected_day);


                loading_setka.LoadPredmetVt_800(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetVt_945(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetVt_1150(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetVt_1335(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetVt_1540(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetVt_1725(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetVt_1910(rw, listBoxTeacher_2, selected_day);



                loading_setka.LoadPredmetSr_800(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetSr_945(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetSr_1150(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetSr_1335(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetSr_1540(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetSr_1725(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetSr_1910(rw, listBoxTeacher_2, selected_day);



                loading_setka.LoadPredmetCht_800(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetCht_945(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetCht_1150(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetCht_1335(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetCht_1540(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetCht_1725(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetCht_1910(rw, listBoxTeacher_2, selected_day);



                loading_setka.LoadPredmetPt_800(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetPt_945(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetPt_1150(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetPt_1335(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetPt_1540(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetPt_1725(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetPt_1910(rw, listBoxTeacher_2, selected_day);



                loading_setka.LoadPredmetSb_800(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetSb_945(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetSb_1150(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetSb_1335(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetSb_1540(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetSb_1725(rw, listBoxTeacher_2, selected_day);
                loading_setka.LoadPredmetSb_1910(rw, listBoxTeacher_2, selected_day);
            }
        }

        private void Delete_Ned(object sender, RoutedEventArgs e)
        {
            if(Type_nedelya.Text == "Нечетная неделя")
            {
                DataBase d1 = new DataBase();
                d1.dbConnection();
                d1.Delete_Ned("Нечетная неделя");
            }

            if (Type_nedelya.Text == "Четная неделя")
            {
                DataBase d1 = new DataBase();
                d1.dbConnection();
                d1.Delete_Ned("Четная неделя");
            }
        }
    }
}