using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class Movie : Title
    {
        private double _duration;
        public Movie(string name, double? rating, string genreName, double duration) : base(name, rating, genreName)
        {
            Duration = duration;
        }
        public double Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        public override string ToString()
        {
            return (String.Format("{0} has a run time of {1} minutes.", Name, Duration));
        }
    }
}
