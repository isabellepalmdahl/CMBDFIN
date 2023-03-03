using CMDb_Grupp10_IWA.Models.Dtos;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp10_IWA.Repositories
{
    public class MockRepository : ICmdbRepository
    {
        #region Variables
        private readonly string basePath;
        #endregion

        #region Constructors
        public MockRepository(IWebHostEnvironment environment)
        {
            basePath = $@"{environment.ContentRootPath}\Mock\";
        }
        #endregion

        #region Tasks
        public async Task<IEnumerable<MovieLibraryDto>> GetTopMoviesAsync()
        {
            await Task.Delay(0);
            return GetTestData<IEnumerable<MovieLibraryDto>>("cmdbtop5.json");
        }

        public async Task<IEnumerable<MovieSuggestionsDto>> GetPopularMoviesAsync()
        {
            await Task.Delay(0);
            return GetTestData<IEnumerable<MovieSuggestionsDto>>("cmdbpopular4.json");
        }

        public async Task<IEnumerable<MovieLibraryDto>> GetAllMoviesAsync()
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }

        public async Task<MovieLibraryDto> GetSelectedMovieAsync(string id)
        {
            await Task.Delay(0);
            return GetTestData<MovieLibraryDto>("cmdblotrmovie.json");
        }

        public Task<MovieLibraryDto> PostLike(string id)
        {
            //return GetTestData<MovieLibraryDto>("cmdblotrmovie.json/like");
            throw new NotImplementedException();
        }

        public Task<MovieLibraryDto> PostDislike(string id)
        {
            //return GetTestData<MovieLibraryDto>("cmdblotrmovie.json/dislike");
            throw new NotImplementedException();
        }

        private T GetTestData<T>(string testfile)
        {
            var path = $"{basePath}{testfile}";
            string data = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(data);
        }
        #endregion
    }
}
