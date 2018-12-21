using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Xamarin
{

    public class salarymoney
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        //public string Name { get; set; }
        public int Spay { get; set; }
        public int Num { get; set; }
    }

    /*public class Mainincome
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public DateTime Day { get; set; }
        public int Income { get; set; }
    }*/
}
