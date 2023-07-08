using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrelloTeacher
{
    class TaskDay
    {
        string teacher;
        string date;
        string group;
        string cabinet;
        string time;
        public TaskDay()
        {
            teacher = "";
            date = "";
            group = "";
            cabinet = "";
            time = "";
        }

        public TaskDay(string teacher, string date, string group, string cabinet, string time)
        {
            this.teacher = teacher;
            this.date = date;
            this.group = group;
            this.cabinet = cabinet;
            this.time = time;

        }

        public string Teacher
        {
            get
            {
                return teacher;
            }

            set
            {
                teacher = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Group
        {
            get
            {
                return group;
            }

            set
            {
                group = value;
            }
        }

        public string Cabinet
        {
            get
            {
                return cabinet;
            }

            set
            {
                cabinet = value;
            }
        }

        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }
    }
}
