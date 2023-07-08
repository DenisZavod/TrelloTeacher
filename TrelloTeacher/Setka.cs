using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrelloTeacher
{
    class Setka
    {
        string time;
        string pn;
        string vt;
        string sr;
        string cht;
        string pt;
        string sb;

        public Setka()
        {
            time = "";
            pn = "";
            vt = "";
            sr = "";
            cht = "";
            pt = "";
            sb = "";
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
        public string Pn
        {
            get
            {
                return pn;
            }
            set
            {
                pn = value;
            }
        }

        public string Vt
        {
            get
            {
                return vt;
            }

            set
            {
                vt = value;
            }
        }

        public string Sr
        {
            get
            {
                return sr;
            }

            set
            {
                sr = value;
            }
        }

        public string Cht
        {
            get
            {
                return cht;
            }

            set
            {
                cht = value;
            }
        }

        public string Pt
        {
            get
            {
                return pt;
            }

            set
            {
                pt = value;
            }
        }
        public string Sb
        {
            get
            {
                return sb;
            }

            set
            {
                sb = value;
            }
        }
    }
}
