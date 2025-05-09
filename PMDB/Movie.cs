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
        var movie = new MovieBuilder()
            .WithRandomId()
            .WithName("Jaws")
            .WithGenre("Thriller")
            .WithDirector("Steven Spielberg")
            .WithWriter("Peter Benchley")
            .WithActor("Roy Scheider")
            .WithActor("Richard Dreyfuss")
            .WithActor("Robert Shaw")
            .WithYearOfRelease(1975)
            .WithDurationInMinutes(124)
            .WithDescription("A killer shark")
            .Build();

        // test goes here
    }

    ///  More tests

    public void MovieTest4()
    {
        var movie = new MovieBuilder()
            .WithId("C54EF8AD-E00C-4B26-BD39-47CC547D2C0D")
            .WithName("Jaws: The Revenge")
            .Build();

        Assert.That(movie.Ratings.Max(r => r.Score), Is.EqualTo(0));
    }

    public void MovieTest5()
    {
        // This test doesn't need to initialise anything, it just needs a valid movie instance
        var movie = new MovieBuilder().Build();
        // test
    }

    public void Add_The_Meg_For_Testing()
    {
        var movie = new Movie(Guid.NewGuid(), "The Meg", "Science Fiction", 2018, new Person("Jon Turteltaub"),
            new List<Person> { new Person("Dean Georgans"), new Person("Jon Hoeber"), new Person("Erich Hoeber") },
            new List<Person>
                { new Person("Jason Statham"), new Person("Ruby Rose") }, 118,
            "A giant prehistoric killer shark", new List<StarRating>());
        // test goes here
    }
}