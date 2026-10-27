using System.Collections.Generic;
using Group19_Lab2_Winforms_Oosu.Models;

namespace Group19_Lab2_Winforms_Oosu.Services
{
    public class SystemController
    {
        // In-memory databas för studenter
        private List<Student> studenter;
        private int nastaStudentId = 1;

        public SystemController()
        {
            studenter = new List<Student>();

            // Fyll systemet med testdata
            FyllMedTestData();
        }

        private void FyllMedTestData()
        {
            RegistreraStudent("Kalle");
            RegistreraStudent("Lisa");
            RegistreraStudent("Admin"); // testdata
        }

        // Metod för att logga in
        public Student HittaStudent(string namn)
        {
            foreach (Student s in studenter)
            {
                // stora/små bokstäver
                if (s.Namn.ToLower() == namn.ToLower())
                {
                    return s;
                }
            }
            return null; // Returnerar null om studenten inte finns
        }

        // registrera ny student
        public bool RegistreraStudent(string namn)
        {
            // Kontrollera så namnet inte redan är upptaget
            if (HittaStudent(namn) != null)
            {
                return false;
            }

            // Skapa nytt objekt och lägg till i listan
            Student nyStudent = new Student(nastaStudentId, namn);
            studenter.Add(nyStudent);
            nastaStudentId++;

            return true;
        }
    }
}