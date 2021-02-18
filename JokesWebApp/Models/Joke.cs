using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Joke
    {
        //getters/setters
        public int Id { get; set; }
        public string JokeQuestion { get; set; }

        public string JokeAnswer { get; set; }

        //constructor
        public Joke()
        {

        }
    }
}
