namespace PMDB;

public class Movie
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public string Genre { get; set; }

    public int YearOfRelease { get; set; }

    public Movie(Guid id, string name, string genre, int year)
    {
        Id = id;
        Name = name;
        Genre = genre;
        YearOfRelease = year;
    }
}
public class MovieTests
{
    public void MovieTest()
    {
        var movie = new Movie(Guid.NewGuid(), "Jaws", "Thriller", 1975);
        // test goes here
    }

    public void MovieTest2()
    {
        var movie = new Movie(Guid.NewGuid(), "Jaws 2", "Thriller", 1978);
        // test goes here
    }

    public void MovieTest3()
    {
        var movie = new Movie(Guid.NewGuid(), "Jaws 3-D", "Thriller", 1983);
        // test goes here
    }
}