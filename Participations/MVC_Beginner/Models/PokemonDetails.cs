namespace MVC_Beginner.Models
{
    public class PokemonDetails
    {

        public string name { get; set; }

        public Sprite sprites { get; set; }
    }

    public class Sprite
    {
        public string front_default { get; set; }
    }
}
