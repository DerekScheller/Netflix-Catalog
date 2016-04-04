using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class Episode
    {
        protected double? _rating;
        protected int _episodeNumber;
        public Episode(double? rating, int episodeNumber)
        {
            Rating = rating;
            EpisodeNumber = episodeNumber;
        }
        public double? Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        public int EpisodeNumber
        {
            get { return _episodeNumber; }
            set { _episodeNumber = value; }
        }
    }
}
