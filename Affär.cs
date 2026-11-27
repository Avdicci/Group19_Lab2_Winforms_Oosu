using Group19_Lab2_Winforms_Oosu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group19_Lab2_Winforms_Oosu
{
    public class Affär
    {
        public int Id { get; private set; }
        public DateTime Datum { get; private set; }
        public string Status { get; private set; }
        public Student Köpare { get; private set; }
        public Annons Annons { get; private set; }

        public Affär(int id, Student köpare, Annons annons)
        {
            Id = id;
            Datum = DateTime.Now;
            Status = "Reserverad";
            Köpare = köpare;
            Annons = annons;
            Annons.UppdateraStatus("Reserverad");
        }
    }
}
