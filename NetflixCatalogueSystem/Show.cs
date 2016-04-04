using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class Show : Title
    {
        public List<Episode> EpisodeCatalog;
        public Show(string name, double? rating, string genreName) : base(name, rating, genreName)
        {
            EpisodeCatalog = new List<Episode>();
        }
        public double? AggregateRatings()
        {
            double? seriesRating = 0;
            foreach (Episode episodeInSeries in EpisodeCatalog)
            {

                seriesRating += episodeInSeries.Rating;
            }
            seriesRating = seriesRating / EpisodeCatalog.Count;
            return seriesRating;
        }
        public override double? Rating
        {
            get
            {
                if (EpisodeCatalog == null)
                {
                    _rating = 0;
                }
                else
                {
                    _rating = AggregateRatings();
                }
                return _rating;
            }
        }
        public void AddEpisodeToShow(Episode recentEpisode)
        {
            EpisodeCatalog.Add(recentEpisode);
        }
        public override string ToString()
        {
            return (String.Format("{0} is a TV series containing {1} episodes.", Name, EpisodeCatalog.Count));
        }
    }
}
