using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    class View
    {
        public StringBuilder PrintAGenre(Genre genreList)
        {
            StringBuilder WriteList = new StringBuilder();
            foreach (Title title in genreList)
            {
                WriteList.AppendLine(String.Format("{0} has a rating of {1} and is in the {2} Genre.", title.Name, title.Rating, title.GenreName));              
            }
            return WriteList;
        }
    }
}
