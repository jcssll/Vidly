using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        //represents the state and behavior - also referred to as 
        //problem domain? Properties used to represent a state
        public int id { get; set; }
        public string name { get; set; }
    } 
    // {controller//action//id}
    // We need to come up with a Movies/random => Now go to controller
}