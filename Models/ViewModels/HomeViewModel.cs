using CMDb_Grupp10_IWA.Models.Dtos;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp10_IWA.Models.ViewModels
{
    public class HomeViewModel
    {
        #region Properties
        public List<MovieDto> CompleteMovies { get; set; } 
        public List<MovieDto> SuggestedMovies { get; set; }
        #endregion

        #region Private methods
        /// <summary>
        /// combines info from CMDb and OMDb APIs on top movies to list
        /// </summary>
        /// <param name="cmdbmovies"></param>
        /// <param name="omdbmovies"></param>
        /// <returns>Combined movie list</returns>
        private List<MovieDto> CombineMovies(IEnumerable<MovieLibraryDto> cmdbmovies, IEnumerable<MovieDto> omdbmovies)
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

        /// <summary>
        /// combines info from CMDb and OMDb APIs on popular movies to list
        /// </summary>
        /// <param name="cmdbmovies"></param>
        /// <param name="omdbmovies"></param>
        /// <returns>Combined movie list</returns>
        private List<MovieDto> CombineSuggestedMovies(IEnumerable<MovieSuggestionsDto> cmdbsuggestedmovies, IEnumerable<MovieDto> omdbsuggestedmovies)
        {
            foreach (var movie1 in cmdbsuggestedmovies)
            {
                foreach (var movie2 in omdbsuggestedmovies)
                {

                    if (movie2.imdbId == movie1.imdbId)
                    {
                        movie1.numberOfDislikes = movie2.numberOfDislikes;
                        movie1.numberOfLikes = movie2.numberOfLikes;
                    }
                }
            }
            return omdbsuggestedmovies.ToList();
        }
        #endregion

        #region Constructors
        public HomeViewModel(IEnumerable<MovieLibraryDto> cmdbmovies, IEnumerable<MovieDto> omdbmovies, IEnumerable<MovieSuggestionsDto> cmdbsuggestedmovies, IEnumerable<MovieDto> omdbsuggestedmovies)
        {
            CompleteMovies = CombineMovies(cmdbmovies, omdbmovies);
            SuggestedMovies = CombineSuggestedMovies(cmdbsuggestedmovies, omdbsuggestedmovies);
        }

        public HomeViewModel()
        {
            
        }
        #endregion
    }
}
