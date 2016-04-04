using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class Genre : IEnumerable
    {
        public List<Title> GenreTitleList;
        public Genre()
        {
            GenreTitleList = new List<Title>();
        }
        public void AddTitleToGenre(Title recentTitle)
        {
            GenreTitleList.Add(recentTitle);
        }
        public IEnumerator GetEnumerator()
        {
            for (int listPlace = 0; listPlace < GenreTitleList.Count; listPlace++)
            {
                yield return GenreTitleList[listPlace];
            }
        }
        public static Genre operator +(Genre genreTitle, Title title)
        {
            Genre aggregatedGenre = new Genre();
            aggregatedGenre = genreTitle;
            aggregatedGenre.AddTitleToGenre(title);
            return aggregatedGenre;
        }
        public static Genre operator +(Genre titleFirst, Genre titleSecond)
        {
            Genre aggregatedGenre = new Genre();
            if (titleFirst.Equals(titleSecond))
            {
                aggregatedGenre = titleFirst;
            }
            else
            {
                foreach (Title title in titleFirst)
                {
                    aggregatedGenre.AddTitleToGenre(title);
                }
                foreach (Title title in titleSecond)
                {
                    aggregatedGenre.AddTitleToGenre(title);
                }
            }
            return aggregatedGenre;
        }
    }
}