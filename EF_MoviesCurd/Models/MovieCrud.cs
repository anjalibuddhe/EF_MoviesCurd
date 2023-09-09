namespace EF_MoviesCurd.Models
{
    public class MovieCrud
    {

        ApplicationDbContext context;
        public MovieCrud(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Movie> GetMovies()
        {
            return context.Movies.Where(x => x.IsActive == 1).ToList();
        }


        public Movie GetMovieById(int id)
        {
            var movies = context.Movies.Where(x => x.Id == id).FirstOrDefault();
            return movies;
        }


        public int AddMovie(Movie movie)
        {
            movie.IsActive = 1;
            int result = 0;
            context.Movies.Add(movie); // add new record in to the DbSet
            result = context.SaveChanges(); // update the change from DbSet to DB
            return result;
        }
        public int UpdateMovie(Movie movie)
        {

            int result = 0;
            // search from dbset
            var m = context.Movies.Where(x => x.Id == movie.Id).FirstOrDefault();
            if (m != null)
            {
                m.Name = movie.Name; // b object contains old data book obj contains new data
                m.ReleaseDate = movie.ReleaseDate;
                m.Type = movie.Type;
                m.Stars = movie.Stars;
                m.IsActive = 1;
                result = context.SaveChanges(); // update the change from DbSet to DB
            }

            return result;
        }
        public int DeleteMovie(int id)
        {


            int result = 0;
            // search from dbset
            var m = context.Movies.Where(x => x.Id == id).FirstOrDefault();
            if (m != null)
            {
                m.IsActive = 0;
                result = context.SaveChanges(); // update the change from DbSet to DB
            }


            return result;
        }

    }
}

