using CMDb_Grupp10_IWA.Models;
using CMDb_Grupp10_IWA.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp10_IWA.Repositories
{
    public interface ICmdbRepository
    {
        Task<IEnumerable<MovieLibraryDto>> GetTopMoviesAsync();
        Task<IEnumerable<MovieSuggestionsDto>> GetPopularMoviesAsync();
        Task<IEnumerable<MovieLibraryDto>> GetAllMoviesAsync();
        Task<MovieLibraryDto> GetSelectedMovieAsync(string id);
        Task<MovieLibraryDto> PostLike(string id);
        Task<MovieLibraryDto> PostDislike(string id);
    }
}
