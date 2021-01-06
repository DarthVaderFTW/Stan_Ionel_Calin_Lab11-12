using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace App1.Models
{
    public class NoteActivity
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(Agenda))]
        public int AgendaID { get; set; }
        public int ActivityID { get; set; }
    }
}

