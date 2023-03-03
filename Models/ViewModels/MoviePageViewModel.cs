using CMDb_Grupp10_IWA.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp10_IWA.Models.ViewModels
{
    public class MoviePageViewModel
    {
        #region Properties
        public List<MovieDto> CompleteMovies { get; set; }
        public MovieDto Completeselectedmovie { get; set; }
        #endregion

        #region Constructors
        public MoviePageViewModel(MovieLibraryDto cmdbselectedmovie, MovieDto omdbselectedmovie)
        {
            Completeselectedmovie = CombineSelectedMovie(cmdbselectedmovie, omdbselectedmovie);
        }
      
        public MoviePageViewModel(IEnumerable<MovieLibraryDto> cmdbmovies, IEnumerable<MovieDto> omdbmovies)
        {
            CompleteMovies = CombineMovies(cmdbmovies, omdbmovies).ToList();
        }

        public MovieDto CombineSelectedMovie(MovieLibraryDto cmdbselectedmovie, MovieDto omdbselectedmovie)
        {
            if (omdbselectedmovie.imdbId == cmdbselectedmovie.imdbId)
            {
                omdbselectedmovie.numberOfDislikes = cmdbselectedmovie.numberOfDislikes;
                omdbselectedmovie.numberOfLikes = cmdbselectedmovie.numberOfLikes;
            }
            return omdbselectedmovie;
        }

        public List<MovieDto> CombineMovies(IEnumerable<MovieLibraryDto> cmdbmovies, IEnumerable<MovieDto> omdbmovies)
        {
            foreach (var movie1 in cmdbmovies)
            {
                foreach (var movie2 in omdbmovies)
                {

                    if (movie2.imdbId == movie1.imdbId)
                    {
                        movie2.numberOfDislikes = movie1.numberOfDislikes;
                        movie2.numberOfLikes = movie1.numberOfLikes;
                    }
                }
            }
            return omdbmovies.ToList();
        }

        public MoviePageViewModel()
        {

        }
        #endregion
    }
}
