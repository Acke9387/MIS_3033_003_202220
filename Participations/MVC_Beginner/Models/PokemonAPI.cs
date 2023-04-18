namespace MVC_Beginner.Models
{
    public class PokemonAPI
    {
        public List<Pokemon> results { get; set; }
    }

    public class Pokemon
    {

        public string name { get; set; }

        public string url { get; set; }

    }
}
