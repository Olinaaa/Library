using System;
using System.Collections.Generic;

#nullable disable

namespace Library
{
    public partial class Книги
    {
        public int КодКниги { get; set; }
        public string НазваниеКниги { get; set; }
        public int Год { get; set; }
        public string ФиоАвтора { get; set; }

        public virtual Авторы ФиоАвтораNavigation { get; set; }
    }
}
