namespace pokemon
{
    public class Player
    {   
        List<Position> visitedPlaces;
        Position currentPosition;

        public Player()
        {
            this.currentPosition = new Position();
            this.visitedPlaces = new List<Position>();
            this.visitedPlaces.Add((new Position()));
        }

        ///Change the current position of player according direction
        public void Move(string input)
        {
            char[] directions;
            directions = input.ToCharArray();
            foreach (var direction in directions)
            {
                switch (direction)
                {   
                    //add y
                    case 'N':
                        this.currentPosition.y ++;
                        break;
                    //sub y
                    case 'S': 
                        this.currentPosition.y --;
                        break;
                    //add x
                    case 'E': 
                        this.currentPosition.x ++;
                        break;
                    //sub x
                    case 'O': 
                        this.currentPosition.x --;
                        break;
                }
                if (!this.visitedPlaces.Exists(p => p.x == this.currentPosition.x && p.y == this.currentPosition.y))
                    this.visitedPlaces.Add(this.currentPosition.Clone());
            }
        }
        ///Return the numbers of Pokemons collected
        public double NumberPokemons()
        {
            return this.visitedPlaces.Count();
        }
    }
}