using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows;

namespace TrelloTeacher
{
    public  class Nedelya
    {
        public void CreatePonedelnikTeacher(string predmet, string teacher, string day, string time, string group, string kabinet) // записываем понедельник конкретному преподавателю
        {
              DataSet ds_poned = new DataSet();
            DataTable dt_poned = new DataTable();
            dt_poned.TableName = "Pn";
            dt_poned.Columns.Add("Predmet");
            dt_poned.Columns.Add("Teacher");
            dt_poned.Columns.Add("Day");
            dt_poned.Columns.Add("Time");
            dt_poned.Columns.Add("Group");
            dt_poned.Columns.Add("Kabinet");
            ds_poned.Tables.Add(dt_poned);

            DataRow cr_poned = ds_poned.Tables["Pn"].NewRow();

            cr_poned[0] = predmet;
            cr_poned[1] = teacher;
            cr_poned[2] = day;
            cr_poned[3] = time;
            cr_poned[4] = group;
            cr_poned[5] = kabinet;

            ds_poned.Tables["Pn"].Rows.Add(cr_poned);

            string nameXmlFile = teacher + "_" + day + ".xml";
            MessageBox.Show(nameXmlFile);
            FileStream fs = new FileStream(nameXmlFile, FileMode.Create);
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, ds_poned);
            fs.Close();

        }
    }
}
