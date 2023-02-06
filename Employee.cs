using System;
namespace flights_managing
{
    public class Employee
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public Airport Airport { get; set; }
        public Employee() { }
        public Employee(int id, int personId, Person person, string position, decimal salary, Airport airport)
        {
            Id = id;
            Person = person;
            PersonId = personId;
            Position = position;
            Salary = salary;
            Airport = airport;
        }
    }
}
