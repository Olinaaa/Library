using System;
using System.Collections.Generic;

#nullable disable

namespace Library
{
    public partial class ЖанрКниги
    {
        public int? КодЖанра { get; set; }
        public string НазваниеКниги { get; set; }

        public virtual Жанр КодЖанраNavigation { get; set; }
        public virtual Книги НазваниеКнигиNavigation { get; set; }
    }
}
