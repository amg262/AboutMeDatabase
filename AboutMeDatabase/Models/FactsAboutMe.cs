using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AboutMeDatabase.Models
{
    public class FactsAboutMe
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
    }
}
