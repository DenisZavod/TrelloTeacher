using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Controls;
using System.Collections.ObjectModel;

namespace TrelloTeacher
{
    class DataBase
    {
        public string dbFileName;
        public SQLiteConnection dbConn;
        public SQLiteCommand sqlCom;

        public void dbConnection()
        {
            dbFileName = "raspisaniye.sqlite";
            dbConn = new SQLiteConnection("Data Source=" + dbFileName + "; Version=3;");
        }

        public void InsertTask(string teacher, string day, string predmet, string time, string group, string kabinet, string type_nedelya)
        {
            dbConn.Open();
            sqlCom = new SQLiteCommand("INSERT INTO Setka (Teacher , Day , Predmet , Time , St_Group , Kabinet , Type_nedelya) VALUES (@Teacher , @Day , @Predmet , @Time , @St_Group , @Kabinet , @Type_nedelya)");
            sqlCom.Connection = dbConn;
            sqlCom.Parameters.Add("@Teacher", DbType.String).Value = teacher;
            sqlCom.Parameters.Add("@Day", DbType.String).Value = day;
            sqlCom.Parameters.Add("@Predmet", DbType.String).Value = predmet;
            sqlCom.Parameters.Add("@Time", DbType.String).Value = time;
            sqlCom.Parameters.Add("@St_Group", DbType.String).Value = group;
            sqlCom.Parameters.Add("@Kabinet", DbType.String).Value = kabinet;
            sqlCom.Parameters.Add("@Type_nedelya", DbType.String).Value = type_nedelya;
            sqlCom.ExecuteNonQuery();
            dbConn.Close();
        }

        public void LoadTeacher(ListBox lsb)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT DISTINCT Teacher FROM Setka");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);

            foreach (DataRow item in tb.Rows)
            {
                lsb.Items.Add(item["Teacher"].ToString());
            }
            dbConn.Close();
        }

        public void LoadPredmetPn_800(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Понедельник' AND Time = '8.00 - 9.35' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[0].Pn = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetPn_945(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Понедельник' AND Time = '9.45 - 11.20' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[1].Pn = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetPn_1150(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned) 
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Понедельник' AND Time = '11.50 - 13.25' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[2].Pn = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetPn_1335(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Понедельник' AND Time = '13.35 - 15.10' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[3].Pn = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetPn_1540(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Понедельник' AND Time = '15.40 - 17.15' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[4].Pn = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetPn_1725(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Понедельник' AND Time = '17.25 - 19.00' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[5].Pn = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetPn_1910(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Понедельник' AND Time = '19.10 - 20.45' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[6].Pn = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }





        public void LoadPredmetVt_800(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Вторник' AND Time = '8.00 - 9.35' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[0].Vt = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetVt_945(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Вторник' AND Time = '9.45 - 11.20' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[1].Vt = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetVt_1150(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Вторник' AND Time = '11.50 - 13.25' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[2].Vt = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetVt_1335(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Вторник' AND Time = '13.35 - 15.10' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[3].Vt = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetVt_1540(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Вторник' AND Time = '15.40 - 17.15' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[4].Vt = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetVt_1725(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Вторник' AND Time = '17.25 - 19.00' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[5].Vt = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetVt_1910(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Вторник' AND Time = '19.10 - 20.45' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[6].Vt = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }




        public void LoadPredmetSr_800(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Среда' AND Time = '8.00 - 9.35' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[0].Sr = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetSr_945(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Среда' AND Time = '9.45 - 11.20' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[1].Sr = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetSr_1150(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Среда' AND Time = '11.50 - 13.25' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[2].Sr = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetSr_1335(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Среда' AND Time = '13.35 - 15.10' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[3].Sr = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetSr_1540(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Среда' AND Time = '15.40 - 17.15' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[4].Sr = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetSr_1725(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Среда' AND Time = '17.25 - 19.00' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[5].Sr = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetSr_1910(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Среда' AND Time = '19.10 - 20.45' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[6].Sr = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }




        public void LoadPredmetCht_800(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Четверг' AND Time = '8.00 - 9.35' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[0].Cht = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetCht_945(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Четверг' AND Time = '9.45 - 11.20' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[1].Cht = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetCht_1150(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Четверг' AND Time = '11.50 - 13.25' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[2].Cht = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetCht_1335(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Четверг' AND Time = '13.35 - 15.10' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[3].Cht = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetCht_1540(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Четверг' AND Time = '15.40 - 17.15' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[4].Cht = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetCht_1725(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Четверг' AND Time = '17.25 - 19.00' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[5].Cht = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetCht_1910(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT  Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Четверг' AND Time = '19.10 - 20.45' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[6].Cht = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }



        public void LoadPredmetPt_800(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT  Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Пятница' AND Time = '8.00 - 9.35' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[0].Pt = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetPt_945(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT  Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Пятница' AND Time = '9.45 - 11.20' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[1].Pt = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetPt_1150(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT  Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Пятница' AND Time = '11.50 - 13.25'AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[2].Pt = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetPt_1335(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT  Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Пятница' AND Time = '13.35 - 15.10' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[3].Pt = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetPt_1540(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT  Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Пятница' AND Time = '15.40 - 17.15' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[4].Pt = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetPt_1725(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT  Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Пятница' AND Time = '17.25 - 19.00' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[5].Pt = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetPt_1910(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT  Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Пятница' AND Time = '19.10 - 20.45' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[6].Pt = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }



        public void LoadPredmetSb_800(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT  Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Суббота' AND Time = '8.00 - 9.35' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[0].Sb = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetSb_945(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT  Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Суббота' AND Time = '9.45 - 11.20' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[1].Sb = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetSb_1150(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT  Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Суббота' AND Time = '11.50 - 13.25' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[2].Sb = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetSb_1335(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT  Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Суббота' AND Time = '13.35 - 15.10' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[3].Sb = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetSb_1540(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT  Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Суббота' AND Time = '15.40 - 17.15' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[4].Sb = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetSb_1725(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT  Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Суббота' AND Time = '17.25 - 19.00' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[5].Sb = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadPredmetSb_1910(ObservableCollection<Setka> rw_dgw, ListBox lsb, string type_ned)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT  Predmet FROM Setka WHERE Teacher ='{0}' AND Day = 'Суббота' AND Time = '19.10 - 20.45' AND Type_Nedelya = '{1}'", lsb.SelectedValue, type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);
            try
            {
                DataRow item = tb.Rows[0];
                rw_dgw[6].Sb = item[0].ToString();
                dbConn.Close();
            }

            catch (IndexOutOfRangeException)
            {
                dbConn.Close();
                return;
            }

        }

        public void LoadFullInformation(string teacher , string time , string day , string predmet , string type , Label group , Label kabinet)
        {
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT * FROM Setka WHERE Teacher = '{0}'  AND Time = '{1}' AND Day = '{2}' and Predmet = '{3}' AND Type_Nedelya = '{4}'" , 
                teacher , time , day , predmet , type);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);

            foreach (DataRow item in tb.Rows)
            {
                group.Content = item["St_Group"].ToString();
            }

            foreach (DataRow item2 in tb.Rows)
            {
                kabinet.Content = item2["Kabinet"].ToString();
            }

            dbConn.Close();
        }

        public string SelectIdForUpdate(string teacher , string day , string predmet , string time , string gruppa , string kabinet , string type_ned)
        {
            string id = "";
            dbConn.Open();
            DataTable tb = new DataTable();
            string sql_query = string.Format("SELECT Id from Setka WHERE Teacher = '{0}' and Day = '{1}' and Predmet = '{2}' and Time = '{3}' and St_Group = '{4}' and Kabinet = '{5}' and Type_Nedelya = '{6}'",
                teacher, day, predmet, time, gruppa , kabinet , type_ned);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, dbConn);
            adapter.Fill(tb);

            foreach (DataRow item in tb.Rows)
            {
                id = item[0].ToString();
            }


            dbConn.Close();
            return id;
        }

        public void UpdateCellSetka(string teacher, string day, string predmet, string time, string gruppa, string kabinet, string type_ned , int id)
        {
            dbConn.Open();
            
            string sql_query = string.Format("UPDATE Setka SET Predmet = '{0}', Teacher = '{1}', Day = '{2}', Time = '{3}', St_Group = '{4}', Kabinet = '{5}', Type_Nedelya = '{6}' WHERE id = {7};",
                predmet, teacher, day, time, gruppa, kabinet, type_ned, id);
            sqlCom = new SQLiteCommand(sql_query);
            sqlCom.Connection = dbConn;
            sqlCom.ExecuteNonQuery();
            dbConn.Close();
        }

        public void DeleteRowSetka(int id)
        {
            dbConn.Open();

            string sql_query = string.Format("DELETE FROM Setka where Id = {0}", id);
            sqlCom = new SQLiteCommand(sql_query);
            sqlCom.Connection = dbConn;
            sqlCom.ExecuteNonQuery();
            dbConn.Close();
        }

        public void Delete_Ned(string type_ned)
        {
            dbConn.Open();

            string sql_query = string.Format("DELETE FROM Setka where Type_Nedelya = '{0}'", type_ned);
            sqlCom = new SQLiteCommand(sql_query);
            sqlCom.Connection = dbConn;
            sqlCom.ExecuteNonQuery();
            dbConn.Close();
        }
    }
}
