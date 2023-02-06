namespace flights_managing
{
    public class Passenger
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
        public string Country { get; set; }
        public string DocumentNumber { get; set; }
        public string Nationality { get; set; }
        public DateOnly DocumentExpirityDate { get; set; } 

        public Passenger() { }
        public Passenger(int id, Person person, int personId, string country, string documentNumber, string nationality, DateOnly documentExpirityDate)
        {
            Id = id;
            Person = person;
            PersonId = personId;
            Country = country;
            DocumentNumber = documentNumber;
            Nationality = nationality;
            DocumentExpirityDate = documentExpirityDate;
        }
    }
}
