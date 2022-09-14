

namespace pokemon
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string input;   
            bool inputValido;                     
            Player mainPlayer = new Player();
            Console.WriteLine("Olá Ash! Vamos apanhar pokémons!?");
            
            do
            {
                Console.WriteLine("Digite o caminho (N - norte, S - sul, E - este ou O - oeste):");
                input = Console.ReadLine();
                try
                {
                    mainPlayer.Move(input);
                    Console.WriteLine($"Ash você foi fantástico. Apanhou { mainPlayer.NumberPokemons() } Pokemons.");
                    inputValido = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    inputValido = false;
                }
            } while (!inputValido);
        }
    }
}