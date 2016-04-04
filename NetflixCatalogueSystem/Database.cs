using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    public class Database
    {
        View view = new View();
        Genre Drama = new Genre();
        Genre Action = new Genre();
        Genre Comedy = new Genre();
        Movie TinkerTailorSolderSpy = new Movie("Tinker Tailor Solder Spy", 5, "Drama", 185);
        Show Seinfeld = new Show("Seinfeld", 5,"Comedy");
        Movie DieHard = new Movie("DieHard", 3, "Action", 135);
        Show WalkingDead = new Show("Walking Dead", 4, "Action");
        Movie Entorage = new Movie("Entorage", 2, "Drama", 120);
        Show Dilbert = new Show("Dilbert", 2, "Comedy");
        Movie RunnerRunner = new Movie("Runner Runner", 3, "Drama", 128);
        Show TimAndEric = new Show("Tim and Eric", 4, "Comedy");
        Movie Ted = new Movie("Ted", 4, "Comedy", 98);
        Show Archer = new Show("Archer", 5, "Comedy");
        Movie BigHero6 = new Movie("Big Hero 6", 4, "Comedy", 80);
        Episode SoupNazi = new Episode(5, 130);
        Episode PirateShirt = new Episode(4, 132);
        Episode CubanConnection = new Episode(5, 130);
        Episode OfficeAntics = new Episode(5, 130);
        Episode CopierIsDown = new Episode(5, 130);
        Episode PirateIsland = new Episode(5, 130);
        Episode ViciousCoupling = new Episode(5, 130);
        Episode HeartOfArchness = new Episode(5, 130);
        Episode TimGetsSome = new Episode(5, 130);
        Episode EricsPoopPants = new Episode(5, 130);
        Episode KidsForRent = new Episode(5, 130);


        public void PrintAllGenres()
        {
            Archer.AddEpisodeToShow(ViciousCoupling);
            Archer.AddEpisodeToShow(HeartOfArchness);
            Archer.AddEpisodeToShow(PirateIsland);
            TimAndEric.AddEpisodeToShow(TimGetsSome);
            TimAndEric.AddEpisodeToShow(EricsPoopPants);
            TimAndEric.AddEpisodeToShow(KidsForRent);
            Seinfeld.AddEpisodeToShow(SoupNazi);
            Seinfeld.AddEpisodeToShow(PirateShirt);
            Seinfeld.AddEpisodeToShow(CubanConnection);
            Dilbert.AddEpisodeToShow(OfficeAntics);
            Dilbert.AddEpisodeToShow(CopierIsDown);
            Action.AddTitleToGenre(DieHard);
            Action.AddTitleToGenre(WalkingDead);
            Action.AddTitleToGenre(RunnerRunner);
            Drama.AddTitleToGenre(Entorage);
            Drama.AddTitleToGenre(TinkerTailorSolderSpy);
            Comedy.AddTitleToGenre(Seinfeld);
            Comedy.AddTitleToGenre(Ted);
            Comedy.AddTitleToGenre(TimAndEric);
            Comedy.AddTitleToGenre(Dilbert);
            Drama.AddTitleToGenre(BigHero6);
            Genre DramaAction = Drama + Action;
            Genre DramaTimAndEric = Drama + TimAndEric;


            foreach(Title title in Comedy)
            {
                Console.WriteLine(title.ToString());

            }
            foreach (Title title in Action)
            {
                Console.WriteLine(title.ToString());

            }
            foreach (Title title in Drama)
            {
                Console.WriteLine(title.ToString());

            }
            foreach (Title title in DramaAction)
            {
                Console.WriteLine(title.ToString());

            }
            foreach (Title title in DramaTimAndEric)
            {
                Console.WriteLine(title.ToString());

            }
            Console.ReadLine();
        }
    }
}
