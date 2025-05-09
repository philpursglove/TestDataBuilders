namespace PMDB;

public class MovieBuilder
{
    private Movie _movie = new Movie()
    { Actors = new List<Person>(), Writers = new List<Person>(), Ratings = new List<StarRating>() };

    public Movie Build()
    {
        return _movie;
    }

    public MovieBuilder WithId(Guid id)
    {
        _movie.Id = id;
        return this;
    }

    public MovieBuilder WithId(string id)
    {
        _movie.Id = Guid.Parse(id);
        return this;
    }

    public MovieBuilder WithName(string name)
    {
        _movie.Name = name;
        return this;
    }

    public MovieBuilder WithGenre(string genre)
    {
        _movie.Genre = genre;
        return this;
    }

    public MovieBuilder WithYearOfRelease(int year)
    {
        _movie.YearOfRelease = year;
        return this;
    }

    public MovieBuilder WithDirector(Person director)
    {
        _movie.Director = director;
        return this;
    }

    public MovieBuilder WithDirector(string name)
    {
        _movie.Director = new Person(name);
        return this;
    }

    public MovieBuilder WithWriter(string name)
    {
        _movie.Writers.Add(new Person(name));
        return this;
    }

    public MovieBuilder WithActor(string name)
    {
        _movie.Actors.Add(new Person(name));
        return this;
    }

    public MovieBuilder WithWriter(Person writer)
    {
        _movie.Writers.Add(writer);
        return this;
    }

    public MovieBuilder WithActor(Person actor)
    {
        _movie.Actors.Add(actor);
        return this;
    }

    public MovieBuilder WithDurationInMinutes(int duration)
    {
        _movie.Duration = duration;
        return this;
    }

    public MovieBuilder WithDescription(string description)
    {
        _movie.Description = description;
        return this;
    }

    public MovieBuilder WithRating(StarRating rating)
    {
        _movie.Ratings.Add(rating);
        return this;
    }

    public MovieBuilder WithRandomId()
    {
        _movie.Id = Guid.NewGuid();
        return this;
    }
}