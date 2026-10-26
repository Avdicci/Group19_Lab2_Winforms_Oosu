namespace Group19_Lab2_Winforms_Oosu.Models
{
    public class Student
    {
        public int Id { get; private set; }
        public string Namn { get; private set; }

        public Student(int id, string namn)
        {
            Id = id;
            Namn = namn;
        }
    }
}
