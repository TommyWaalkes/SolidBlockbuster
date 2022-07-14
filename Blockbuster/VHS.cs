using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    //Always make classes, properties public unless to do otherwise
    public class VHS : IPlay
    {
        //We want current time to always start at 0
        //You may give properties initial values 
        public int CurrentTime { get; set; } = 0;

        //Base - reference to the parent class 
        //If the parent has parameters in its constructor, 
        //The child must call base in it's own constructor to pass values up to the parent 
        //Outside of Constructors, base functions much like the this keyword, 
        //but instead of pointing to itself, it point to its immediate parent

        public void Rewind()
        {
            CurrentTime = 0;
        }

        //VHS wants it own version of the play method 
        public void Play(List<string> scenes)
        {
            if (CurrentTime < scenes.Count)
            {
                string scene = scenes[CurrentTime];
                Console.WriteLine(scene);
                CurrentTime++;
            }
            else
            {
                Rewind();
            }
        }
    }
}
