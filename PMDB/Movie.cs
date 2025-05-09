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
        var movie = new MovieBuilder()
            .WithRandomId()
            .WithName("The Meg")
            .WithGenre("Science Fiction")
            .WithYearOfRelease(2018)
            .WithDirector("Jon Turteltaub")
            .WithWriter("Dean Georgan")
            .WithWriter("Jon Hoeber")
            .WithWriter("Erich Hoeber")
            .WithActor("Jason Statham")
            .WithActor("Ruby Rose")
            .WithDurationInMinutes(118)
            .WithDescription("A giant prehistoric killer shark")
            .Build();
        // test goes here
    }
}