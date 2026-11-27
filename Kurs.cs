using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group19_Lab2_Winforms_Oosu
{
    public class Kurs
    {
        public string KursId { get; private set; }
        public string KursNamn { get; private set; }

        public Kurs(string kursId, string kursNamn)
        {
            KursId = kursId;
            KursNamn = kursNamn;
        }

        public override string ToString() => $"{KursId} - {KursNamn}";
    }
}
