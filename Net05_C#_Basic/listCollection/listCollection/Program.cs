using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listCollection
{
    class Movie
    {
        public int Id;
        public string Name;
        public string Director;
    }
    class PlayMovie
    {
        public void ShowMovie()
        {
            const int index = 2;
            List<Movie> ListMovies = new List<Movie>()
            {
                new Movie{ Id = 1, Name = "Thor 3", Director = "Mavel"},
                new Movie{ Id = 2, Name = "End Game", Director = "Mavel"},
                new Movie{ Id = 4, Name = "BatMan", Director = "DC"},
                new Movie{ Id = 5, Name = "KingKong", Director = "Legendary"},
                new Movie{ Id = 6, Name = "Spider man", Director = "Mavel"},
                new Movie{ Id = 7, Name = "XYZ", Director = "ZYX"},
            };
            ListMovies.Remove(ListMovies[1]);
            List<Movie> ListMoviesSmall = new List<Movie>();
            for (int i = 0; i < ListMovies.Count; i++)
            {
                if (i == index)
                {
                    ListMoviesSmall.Add(ListMovies[i]);
                    ListMovies[i] = new Movie { Id = 10, Name = "Avatar", Director = "World" };
                }
                if (i > index)
                {
                    ListMoviesSmall.Add(ListMovies[i]);
                }
            }
            for (int i = 0; i <= ListMovies.Count; i++)
            {
                if (i > 2)
                {
                    ListMovies.RemoveRange(i, ListMovies.Count - (index + 1));
                    break;
                }
            }
            ListMovies.AddRange(ListMoviesSmall);
            var ListSort = ListMovies.OrderByDescending(x => x.Id);
            Console.WriteLine("List movie not sort");
            ListMovies.ForEach(x => Console.WriteLine(x.Id+"\t "+ x.Name+"\t\t "+ x.Director));
            Console.WriteLine("List movie sort");
            foreach(var item in ListSort)
            {
                Console.WriteLine(item.Id + "\t " + item.Name + "\t\t " + item.Director);
            }
            // search element name is KingKong
            int indexElement = -1;
            const string nameElement = "KingKong";
            for(int i = 0; i< ListMovies.Count; i++)
            {
                if(ListMovies[i].Name == nameElement)
                {
                    indexElement = i;
                    break;
                }
            }
            Console.WriteLine("search element name is KingKong: ");
            Console.WriteLine("Id: "+ListMovies[indexElement].Id + " Director: "+ ListMovies[indexElement].Director);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            PlayMovie playMovie = new PlayMovie();
            playMovie.ShowMovie();
            Console.ReadKey();
        }
    }
}
