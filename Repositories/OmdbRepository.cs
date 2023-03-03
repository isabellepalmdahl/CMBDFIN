using CMDb_Grupp10_IWA.Infrastructure;
using CMDb_Grupp10_IWA.Models;
using CMDb_Grupp10_IWA.Models.Dtos;
using CMDb_Grupp10_IWA.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp10_IWA.Repositories
{
    public class OmdbRepository: IOmdbRepository
    {
        #region Variables
        private readonly IApiClient apiClient;
        private readonly string baseEndpoint = "http://www.omdbapi.com/?apikey=7e6fbf1&";
        #endregion

        #region Constructors
        public OmdbRepository(IApiClient apiClient)
        {
            this.apiClient = apiClient;
        }
        #endregion

        #region Tasks
        public async Task<IEnumerable<MovieDto>> GetMovieAsync(IEnumerable<MovieLibraryDto> movieLibraryDtos)
        {
            List<MovieDto> listOfMovies = new List<MovieDto>();

            foreach (var movie in movieLibraryDtos)
            {
                var result = await apiClient.GetAsync<MovieDto>($"{baseEndpoint}i={movie.imdbId}&plot=full"); 
                listOfMovies.Add(result);
            }
            return listOfMovies;
        }

        public async Task<IEnumerable<MovieDto>> GetSuggestedMovieAsync(IEnumerable<MovieSuggestionsDto> movieSuggestionsDto)
        {
            List<MovieDto> listOfSuggestedMovies = new List<MovieDto>();

            foreach (var movie in movieSuggestionsDto)
            {
                var result = await apiClient.GetAsync<MovieDto>($"{baseEndpoint}i={movie.imdbId}&plot=full");
                listOfSuggestedMovies.Add(result);
            }
            return listOfSuggestedMovies;
        }

        public async Task<IEnumerable<MovieDto>> GetMovieResultAsync(string query)
        {
            var movies = await apiClient.GetAsync<MovieDto>($"{baseEndpoint}i={query}");
            return (IEnumerable<MovieDto>)movies;
        }

        public async Task<MovieDto> GetSelectedMovieInfoAsync(string id)
        {
            var imdbid = id;
            var result = await apiClient.GetAsync<MovieDto>($"{baseEndpoint}i={imdbid}&plot=full");
            return result;
        }
        #endregion
    }
}
