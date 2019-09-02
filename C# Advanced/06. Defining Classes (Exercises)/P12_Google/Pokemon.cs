namespace P12_Google
{
    public class Pokemon
    {
        public Pokemon(string pokemonName, string pokemonType)
        {
            PokemonName = pokemonName;
            PokemonType = pokemonType;
        }

        public string PokemonName { get; set; }

        public string PokemonType { get; set; }

        public override string ToString()
        {
            return $"{PokemonName} {PokemonType}";
        }
    }
}
