using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Pokemon
{
    class AllPokemonAPI
    {
        public int count { get; set; }
        public string next { get; set; }
        public double previeous { get; set; }
        public List<AllPokemonResult> results { get; set; }
        public List<PokieInfo> sprites { get; set; }



    }

    public class PokieInfo

    {
        public double weight { get; set; }
        public double height { get; set; }
        public double id { get; set; }
        public string name{ get; set; }
        public Sprite sprites { get; set; }
        
        public override string ToString()
        {
            return $"Weight: {weight}, Height: {height}";
        }

        
    }

    public class Sprite
    {
        public string front_default { get; set; }
        public string back_default { get; set; }
    }

    public class AllPokemonResult

    {
        public string url { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return name;
        }
    }

    




}
