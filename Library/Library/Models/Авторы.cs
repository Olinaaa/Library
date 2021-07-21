using System;
using System.Collections.Generic;

#nullable disable

namespace Library
{
    public partial class Авторы
    {
        public Авторы()
        {
            Книгиs = new HashSet<Книги>();
        }

        public int КодАвтора { get; set; }
        public string ФиоАвтора { get; set; }
        public DateTime ДеньРождения { get; set; }
        public string Страна { get; set; }

        public virtual ICollection<Книги> Книгиs { get; set; }
    }
}
