using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JSON_GameOfThroneQuote
{
    public class GOTAPI
    {
        public string sentence { get; set; }

        public Character character { get; set; }

        public GOTAPI()
        {
            sentence = string.Empty;
            character = new Character();
        }

    }

    public class Character
    {
        public string name { get; set; }

        public string slug { get; set; }

        public House house { get; set; }

        public Character()
        {
            name = string.Empty;
            slug = string.Empty;
            house = new House();
        }
    }

    public class House
    {
        public string name { get; set; }

        public string slug { get; set; }

        public House()
        {
            name = string.Empty;
            slug = string.Empty;
        }
    }
}
