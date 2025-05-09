using NUnit.Framework;

namespace PMDB;

public class Movie
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Genre { get; set; }
    public int YearOfRelease { get; set; }

    public Person Director { get; set; }
    public List<Person> Writers { get; set; }
    public List<Person> Actors { get; set; }

    public int Duration { get; set; }
    public string Description { get; set; }
    public List<StarRating> Ratings { get; set; }

    public Movie(Guid id, string name, string genre, int year, Person director, List<Person> writers, List<Person> actors, int duration, string description, List<StarRating> ratings)
    {
        Id = id;
        Name = name;
        Genre = genre;
        YearOfRelease = year;
        Director = director;
        Writers = writers;
        Actors = actors;
        Duration = duration;
        Description = description;
        Ratings = ratings;
    }
}

public class MovieTests
{
    public void MovieTest()
    {
        var movie = new Movie(Guid.NewGuid(), "Jaws", "Thriller", 1975, new Person("Steven Spielberg"),
            new List<Person> { new Person("Peter Benchley"), new Person("Carl Gottlieb") },
            new List<Person>
                { new Person("Roy Scheider"), new Person("Richard Dreyfuss"), new Person("Robert Shaw") }, 124,
            "A killer shark", new List<StarRating>());
        // test goes here
    }

    public void MovieTest2()
    {
        var movie = new Movie(Guid.NewGuid(), "Jaws 2", "Thriller", 1978, new Person("Jeannot Szwarc"),
            new List<Person> { new Person("Carl Gottlieb") },
            new List<Person>
                { new Person("Roy Scheider"), new Person("Lorraine Gary") }, 116,
            "Another killer shark", new List<StarRating>());
        // test goes here
    }

    public void MovieTest3()
    {
        var movie = new Movie(Guid.NewGuid(), "Jaws 3-D", "Thriller", 1975, new Person("Joe Alves"),
            new List<Person> { new Person("Carl Gottlieb") },
            new List<Person>
                { new Person("Dennis Quaid"), new Person("Louis Gosset Jr.") }, 98,
            "Yet another killer shark", new List<StarRating>());
        // test goes here
    }

    public void MovieTest4()
    {
        var movie = new Movie(Guid.NewGuid(), "Jaws: The Revenge", "Thriller", 1987, new Person("Joseph Sargent"),
            new List<Person> { new Person("Michael de Guzman") },
            new List<Person>
                { new Person("Lorraine Gary"), new Person("Michael Caine") }, 90,
            "The killer shark goes to the Bahamas", new List<StarRating>());
        Assert.That(movie.Ratings.Max(r => r.Score), Is.EqualTo(0));
    }
}