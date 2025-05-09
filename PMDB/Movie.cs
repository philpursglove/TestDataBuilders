namespace PMDB;

public class Movie
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public Movie(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}

public class MovieTests
{
    public void MovieTest()
    {
        var movie = new Movie(Guid.NewGuid(), "Jaws");
        // test goes here
    }

    public void MovieTest2()
    {
        var movie = new Movie(Guid.NewGuid(), "Jaws 2");
        // test goes here
    }

    public void MovieTest3()
    {
        var movie = new Movie(Guid.NewGuid(), "Jaws 3-D");
        // test goes here
    }
}