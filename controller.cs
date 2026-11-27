using System.Collections.Generic;
using Group19_Lab2_Winforms_Oosu.Models;

namespace Group19_Lab2_Winforms_Oosu.Services
{
    public class SystemController
    {
        private List<Student> studenter = new List<Student>();
        private List<Kurs> kurser = new List<Kurs>();
        private List<Annons> annonser = new List<Annons>();
        private List<Affär> affärer = new List<Affär>();
        private int nastaStudentId = 1;
        private int nastaAnnonsId = 5;

        public SystemController()
        {
            FyllMedTestData();
        }

        private void FyllMedTestData()
        {
            // 1. Skapa studenter
            RegistreraStudent("Kalle");
            RegistreraStudent("Lisa");
            RegistreraStudent("Admin");

            Student kalle = HittaStudent("Kalle");
            Student lisa = HittaStudent("Lisa");

            // 2. Skapa kurser
            Kurs oosu = new Kurs("C1OB1B", "Objektorienterad Systemutveckling 1");
            Kurs databaser = new Kurs("D1DB1A", "Databasteknik");
            kurser.Add(oosu);
            kurser.Add(databaser);

            // 3. Skapa testannonser kopplade till kurser och säljare
            annonser.Add(new KursBok(1, "C# från grunden", 250m, "Bra skick", "Till salu", oosu, kalle, "978-91-44", "Per Karlsson", "Upplaga 3"));
            annonser.Add(new KursBok(2, "Applying UML and Patterns", 420m, "Nyskick", "Till salu", oosu, lisa, "978-01-31", "Craig Larman", "Upplaga 3"));
            annonser.Add(new Kompendium(3, "Övningshäfte Databaser", 80m, "Slitet", "Till salu", databaser, kalle, 45, 2024));
            annonser.Add(new DigitalResurs(4, "SQL Cheat Sheet & Guide", 50m, "Nyskick", "Till salu", databaser, lisa, "PDF", "E-postlänk"));
        }

        public Student HittaStudent(string namn)
        {
            foreach (Student s in studenter)
            {
                if (s.Namn.ToLower() == namn.ToLower())
                    return s;
            }
            return null;
        }

        public bool RegistreraStudent(string namn)
        {
            if (HittaStudent(namn) != null)
                return false;

            studenter.Add(new Student(nastaStudentId++, namn));
            return true;
        }

        public List<Annons> HämtaAllaAnnonser()
        {
            return annonser;
        }

        public bool ReserveraAnnons(Annons valdAnnons, Student köpare, out string meddelande)
        {
            if (valdAnnons == null)
            {
                meddelande = "Ingen annons är vald.";
                return false;
            }

            if (valdAnnons.Säljare == köpare)
            {
                meddelande = "Du kan inte reservera din egen annons.";
                return false;
            }

            if (!valdAnnons.KontrolleraTillgänglig())
            {
                meddelande = "Annonsen är redan reserverad eller såld.";
                return false;
            }

            Affär nyAffär = new Affär(affärer.Count + 1, köpare, valdAnnons);
            affärer.Add(nyAffär);
            meddelande = $"Reservationsbekräftelse: Du har nu reserverat '{valdAnnons.Titel}' av {valdAnnons.Säljare.Namn}!";
            return true;
        }

        public List<Kurs> HämtaKurser()
        {
            return kurser;
        }

        // Visa egna annonser (filtrerar på den inloggade studentens objekt)
        public List<Annons> HämtaMinaAnnonser(Student säljare)
        {
            List<Annons> minaAnnonser = new List<Annons>();
            foreach (Annons a in annonser)
            {
                if (a.Säljare == säljare)
                {
                    minaAnnonser.Add(a);
                }
            }
            return minaAnnonser;
        }

        // Skapa annons (hanterar polymorfism utifrån vald typ)
        public void SkapaAnnons(string typ, string titel, decimal pris, string skick, Kurs kurs, Student säljare, string extra1, string extra2, string extra3)
        {
            Annons nyAnnons = null;

            if (typ == "Kursbok")
            {
                nyAnnons = new KursBok(nastaAnnonsId++, titel, pris, skick, "Till salu", kurs, säljare, extra1, extra2, extra3);
            }
            else if (typ == "Kompendium")
            {
                int.TryParse(extra1, out int sidor);
                int.TryParse(extra2, out int ar);
                nyAnnons = new Kompendium(nastaAnnonsId++, titel, pris, skick, "Till salu", kurs, säljare, sidor, ar);
            }
            else if (typ == "Digital resurs")
            {
                nyAnnons = new DigitalResurs(nastaAnnonsId++, titel, pris, skick, "Till salu", kurs, säljare, extra1, extra2);
            }

            if (nyAnnons != null)
            {
                annonser.Add(nyAnnons);
            }
        }

        // Uppdatera annons
        public void UppdateraAnnons(Annons annons, string nyTitel, decimal nyttPris, string nyttSkick)
        {
            if (annons != null)
            {
                annons.Titel = nyTitel;
                annons.Pris = nyttPris;
                annons.Skick = nyttSkick;
            }
        }

        // Ta bort annons
        public void TaBortAnnons(Annons annons)
        {
            if (annons != null && annonser.Contains(annons))
            {
                annonser.Remove(annons);
            }
        }
    }
}