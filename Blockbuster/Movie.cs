using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
   public class Movie
    {
        //Recipe for creating a class 
        //1) Properties/Variables 
        //2) Constructor(s)
        //3) Method(s) 

        //What do Concrete classes pass to their children? 
        //1) Properties/Variables - pass down as is 
        //2) Constructor(s) - pass down as is 
        //3) Method(s) 

        //Options for passing down methods:
        //1) Regular Method - as is 
        //2) Virtual Method - child has the option to override 
        //3) Add onto a Virtual Method - overide the method, call base in the child, and write the childs own code


        public string Title { get; set; }
        public Genre Category { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }
        public IPlay PlayMethod { get; set; }

        public Movie(string Title, Genre Category, int Runtime, List<string> Scenes, IPlay PlayMethod)
        {
            this.Title = Title;
            this.Category = Category;
            this.Runtime = Runtime;
            this.Scenes = Scenes;
            //This is method injection, I get access to functionality via the interface passed in
            this.PlayMethod = PlayMethod;
        }
        
        public void PrintInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Category: "+ Category);
            Console.WriteLine("Run Time: "+ Runtime);
        }

        public void PrintScenes()
        {
            Console.WriteLine("Scenes: ");
            foreach(string scene in Scenes)
            {
                Console.WriteLine(scene);
            }
        }

        //Virtual == the child has the option to override the method
        //Abstract == the child MUST override this method
        public void Play()
        {
            PlayMethod.Play(Scenes);
        }

        public virtual void PlayWholeMovie()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                string scene = Scenes[i];
                Console.WriteLine($"{i}:{scene}");
            }
        }
    }
}
