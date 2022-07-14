using System;
using System.Collections.Generic;
using System.Text;


namespace Blockbuster
{
    class BlockBusterVideo
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        //You may only initialize values, but you may call any methods outside of another method
        //Movies.Add(new VHS("Die Hard", Genre.Action, 120, dieHardScenes));

        //Directly in a class, you may only declare and initalize properties and declare methods/constructors

        public BlockBusterVideo()
        {
            //Think of this constructor as stocking our shelves in block buster with Movies
            List<string> shrekScenes = new List<string>() { "What are you doing in my swamp", "Shrek meets Donkey", "Castle scene", "Dragon fight scene" };
            DVD d = new DVD();
            Movie m = new Movie("Shrek", Genre.Drama, 120, shrekScenes, d);


            List<string> meanGirls = new List<string>() { "First day at school", "You must wear pink on Wednesdays", "Riot scene", "Who's afraid of Regina?" };

            Movie m2 = new Movie("Mean Girls", Genre.Comedy, 133, meanGirls, d);
            //You cant call the constructor on abstract classes
            //In abstract classes constructors exist for the children 
            //Think of the children!
            //Movie m = new Movie("Shrek", Genre.Comedy, 95, shrekScenes);


            List<string> dieHardScenes = new List<string>() { "Plane scene", "Snape takes over the building", "John McLane sneaks around", "Shoot out by the vault" };
            VHS v = new VHS();
            Movie m3 = new Movie("Die Hard", Genre.Action, 120, dieHardScenes, v);

            List<string> lordOfTheRingsScenes = new List<string>() { "Hobbiton", "Fireworks", "Mines of Moria", "Orcs attack" };
            Movie m4 = new Movie("Fellowship of the Ring", Genre.Drama, 225, lordOfTheRingsScenes, v);



            Movies.Add(m);
           // Movies.Add(m);
            Movies.Add(m2);
            Movies.Add(m3);
            Movies.Add(m4);
        }

        //2 Reasons why we can use the movie class
        //1) Movie is public 
        //2) Movie is in the same namespace as this class
        public Movie GetMovie(int index)
        {
            Movie m = Movies[index];
            return m;
        }


        public void PrintAllMovies()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                string title = m.Title;
                Console.WriteLine($"{i}: {title}");
            }
        }

        public void Checkout()
        {
            Console.WriteLine($"What movie would you like to watch? 0 to {Movies.Count -1}");
            string input = Console.ReadLine();
            int index = int.Parse(input);

            Movie m = GetMovie(index);

            m.Play();
        }
    }
}
