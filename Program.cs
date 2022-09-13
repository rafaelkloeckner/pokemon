namespace pokemon
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = "E";                        
            Player mainPlayer = new Player();
            Console.WriteLine("Olá Ash! Vamos apanhar pokémons!?");
            Console.WriteLine("Digite o caminho (N - norte, S - sul, E - este ou O - oeste):");
            //input = Console.ReadLine();
            mainPlayer.Move(input);
            Console.WriteLine("Ash você foi fantástico. Apanhou " + mainPlayer.NumberPokemons() + " Pokemons.");
        }
    }
}