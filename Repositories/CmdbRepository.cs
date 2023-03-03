using CMDb_Grupp10_IWA.Infrastructure;
using CMDb_Grupp10_IWA.Models;
using CMDb_Grupp10_IWA.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp10_IWA.Repositories
{
    public class CmdbRepository : ICmdbRepository
    {
        #region Variables
        private readonly IApiClient apiClient;
        private readonly string baseEndpoint = "https://grupp9.dsvkurs.miun.se/api";
        #endregion

        #region Constructors
        public CmdbRepository(IApiClient apiClient)
        {
            this.apiClient = apiClient;
        }
        #endregion

        #region Tasks
        public async Task<IEnumerable<MovieLibraryDto>> GetTopMoviesAsync()
        {
            var result = await apiClient.GetAsync<IEnumerable<MovieLibraryDto>>($"{baseEndpoint}/Toplist?sort=desc&count=10&type=ratings"); 
            return result;
        }

        public async Task<IEnumerable<MovieSuggestionsDto>> GetPopularMoviesAsync()
        {
            var suggestion = await apiClient.GetAsync<IEnumerable<MovieSuggestionsDto>>($"{baseEndpoint}/Toplist?sort=desc&count=10&type=popularity");
            return suggestion;
        }

        public async Task<IEnumerable<MovieLibraryDto>> GetAllMoviesAsync()
        {
            var result = await apiClient.GetAsync<IEnumerable<MovieLibraryDto>>($"{baseEndpoint}/Movie");
            return (IEnumerable<MovieLibraryDto>)result;
        }

        public async Task<MovieLibraryDto> GetSelectedMovieAsync(string id)
        {
            var result = await apiClient.GetAsync<MovieLibraryDto>($"{baseEndpoint}/{id}");

            if (result.imdbId == null)
            {
                return null;
            }
            return result;
        }

        public Task<MovieLibraryDto> PostLike(string id)
        {
            var result = apiClient.GetAsync<MovieLibraryDto>($"{baseEndpoint}/{id}/like");
            return result;
        }

        public Task<MovieLibraryDto> PostDislike(string id)
        {
            var result = apiClient.GetAsync<MovieLibraryDto>($"{baseEndpoint}/{id}/dislike");
            return result;
        }
        #endregion
    }
}
