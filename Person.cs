namespace flights_managing
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public char Sex { get; set; }
        public Person() { }
        public Person(string name, string surname, string email, char sex)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Sex = sex;
        }
    }
}