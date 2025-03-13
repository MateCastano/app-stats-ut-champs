using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_FUTSCORE.Entidades
{
    public class E_Player
    {
        public int id { get; set; }
        public string name { get; set; }
        public int goals { get; set; }
        public int assists { get; set; }
        public int id_user { get; set; }
    }
}
