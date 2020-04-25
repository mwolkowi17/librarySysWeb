﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySysWeb.Models
{
    public class Reader
    {
        public Reader(int readerid, string name, string surname)
        {
            ReaderID = readerid;
            Name = name;
            Surname = surname;
        }

        public Reader()
        {

        }

        public Reader(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public int ReaderID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Book> Books { get; set; }
        public string Alias { get; set; }
    }
}
