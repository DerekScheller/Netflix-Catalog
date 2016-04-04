using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public abstract class Title
    {
        protected string _name;
        protected double? _rating;
        protected string _genreName;
        public Title(string name, double? rating, string genreName)
        {
            Name = name;
            Rating = rating;
            GenreName = genreName;
        }
        public Title()
        {
            Name = null;
            Rating = null;
            GenreName = null;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string GenreName
        {
            get { return _genreName; }
            set { _genreName = value; }
        }
        public virtual double? Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        public static Genre operator +(Title titleFirst, Title titleSecond)
        {
            Genre genre = new Genre();
            if (titleFirst.GenreName != titleSecond.GenreName)
            {
            titleFirst.GenreName = titleFirst.GenreName + titleSecond.GenreName;
            titleSecond.GenreName = titleFirst.GenreName + titleSecond.GenreName;
            }
            genre.AddTitleToGenre(titleFirst);
            genre.AddTitleToGenre(titleSecond);
            return genre;
        }
    }
}