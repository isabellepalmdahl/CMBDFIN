using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp10_IWA.Models.Dtos
{
    public class MovieLibraryDto
    {
        #region Properties
        public string imdbId { get; set; }
        public int numberOfLikes { get; set; }
        public int numberOfDislikes { get; set; }
        #endregion
    }
}
