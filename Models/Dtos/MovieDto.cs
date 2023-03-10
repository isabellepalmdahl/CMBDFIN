using CMDb_Grupp10_IWA.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp10_IWA.Models
{
    public class MovieDto
    {
        #region Properties
        public string Title { get; set; }

        public string Plot { get; set; }

        public string Poster { get; set; }

        public string imdbId { get; set; }

        public int numberOfLikes { get; set; } 

        public int numberOfDislikes { get; set; } 

        public string Year { get; set; }

        public string Actors { get; set; }

        public string Released { get; set; }

        public string Runtime { get; set; }

        public string Director { get; set; }
        #endregion
    }
}

