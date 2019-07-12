using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_app.Models.Movie
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public string ReleaseDate { get; set; }
        public string Description { get; set; }
        public string Poster { get; set; }
        public List<Movie> MovieList { get; set; } = new List<Movie>();

        public Movie(string title, string director, string genre, string releaseDate, string description, string poster)
        {
            Title = title;
            Director = director;
            Genre = genre;
            ReleaseDate = releaseDate;
            Description = description;
            Poster = poster;
        }

        public Movie()
        {
        }
    }
}
