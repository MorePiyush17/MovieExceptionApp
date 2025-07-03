namespace MovieException
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfRelease { get; set; }
        public string Genre { get; set; }

        public Movie(int id, string name, int yearOfRelease, string genre)
        {
            Id = id;
            Name = name;
            YearOfRelease = yearOfRelease;
            Genre = genre;
        }
        public Movie()
        {

        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Year: {YearOfRelease}, Genre: {Genre}";
        }
    }
}
