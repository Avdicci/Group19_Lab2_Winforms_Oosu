using Group19_Lab2_Winforms_Oosu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group19_Lab2_Winforms_Oosu
{
    public abstract class Annons
    {
        public int Id { get; private set; }
        public string Titel { get; set; }
        public decimal Pris { get; set; }
        public string Skick { get; set; }
        public string Status { get; set; }
        public Kurs Kurs { get; set; }
        public Student Säljare { get; set; }

        public Annons(int id, string titel, decimal pris, string skick, string status, Kurs kurs, Student säljare)
        {
            Id = id;
            Titel = titel;
            Pris = pris;
            Skick = skick;
            Status = status;
            Kurs = kurs;
            Säljare = säljare;
        }

        public abstract string GetInfo();

        public bool KontrolleraTillgänglig()
        {
            return Status == "Till salu";
        }

        public void UppdateraStatus(string nyStatus)
        {
            Status = nyStatus;
        }

        // Gör att ListBox visar snygg text automatiskt
        public override string ToString()
        {
            return $"[{Status}] {Titel} - {Pris} kr ({Kurs.KursNamn}) | {GetInfo()}";
        }
    }

    public class KursBok : Annons
    {
        public string Isbn { get; set; }
        public string Författare { get; set; }
        public string Upplaga { get; set; }

        public KursBok(int id, string titel, decimal pris, string skick, string status, Kurs kurs, Student säljare, string isbn, string författare, string upplaga)
            : base(id, titel, pris, skick, status, kurs, säljare)
        {
            Isbn = isbn;
            Författare = författare;
            Upplaga = upplaga;
        }

        public override string GetInfo() => $"Kursbok av {Författare}, {Upplaga} (ISBN: {Isbn})";
    }

    public class Kompendium : Annons
    {
        public int AntalSidor { get; set; }
        public int Utgivningsår { get; set; }

        public Kompendium(int id, string titel, decimal pris, string skick, string status, Kurs kurs, Student säljare, int antalSidor, int utgivningsår)
            : base(id, titel, pris, skick, status, kurs, säljare)
        {
            AntalSidor = antalSidor;
            Utgivningsår = utgivningsår;
        }

        public override string GetInfo() => $"Kompendium ({AntalSidor} sidor, {Utgivningsår})";
    }

    public class DigitalResurs : Annons
    {
        public string Filformat { get; set; }
        public string Leveranssätt { get; set; }

        public DigitalResurs(int id, string titel, decimal pris, string skick, string status, Kurs kurs, Student säljare, string filformat, string leveranssätt)
            : base(id, titel, pris, skick, status, kurs, säljare)
        {
            Filformat = filformat;
            Leveranssätt = leveranssätt;
        }

        public override string GetInfo() => $"Digital resurs ({Filformat}, via {Leveranssätt})";
    }
}