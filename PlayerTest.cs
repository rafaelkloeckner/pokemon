using Xunit;

    public class PlayerTest
    {
        [Fact]
        public void Test1()
        {
            pokemon.Player p1 = new pokemon.Player();
            p1.Move("E");
            Assert.Equal(2, p1.NumberPokemons());
        }

        [Fact]
        public void Test2()
        {
            pokemon.Player p2 = new pokemon.Player();
            p2.Move("NESO");
            Assert.Equal(4, p2.NumberPokemons());
        }
        
        [Fact]
        public void Test3()
        {
            pokemon.Player p3 = new pokemon.Player();
            p3.Move("NSNSNSNSNS");
            Assert.Equal(2, p3.NumberPokemons());
        }

        [Fact]
        public void Test4()
        {
            pokemon.Player p4 = new pokemon.Player();
            Assert.Equal(1, p4.NumberPokemons());
        }

        [Fact]
        public void Test5()
        {
            pokemon.Player p5 = new pokemon.Player();
            p5.Move("e");
            Assert.Equal(2, p5.NumberPokemons());
        }

        [Fact]
        public void Test6()
        {
            pokemon.Player p6 = new pokemon.Player();
            p6.Move("EEEENOOOONEEEENOOOONEEEENOOOONEEEENEEEENOOOONEEEENOOOONEEEENOOOONEEEENEEEENOOOONEEEENOOOONEEEENOOOONEEEEN");
            Assert.Equal(106, p6.NumberPokemons());
        }
    }