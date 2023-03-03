using CMDb_Grupp10_IWA.Models;
using CMDb_Grupp10_IWA.Models.Dtos;
using CMDb_Grupp10_IWA.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp10_IWA.Repositories
{
    public interface IOmdbRepository
    {
        Task<IEnumerable<MovieDto>> GetMovieResultAsync(string query);
        Task<IEnumerable<MovieDto>> GetMovieAsync(IEnumerable<MovieLibraryDto> movieLibraryDtos);
        Task<IEnumerable<MovieDto>> GetSuggestedMovieAsync(IEnumerable<MovieSuggestionsDto> movieSuggestionsDto);
        Task<MovieDto> GetSelectedMovieInfoAsync(string id);
    }
}
