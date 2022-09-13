namespace pokemon
{
    ///Position represent current locale in a bidimensional grid
    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }

        public Position()
        {
            this.x = 0;
            this.y = 0;
        }

        public Position Clone()
        {
            return (Position)this.MemberwiseClone();
        }
    }
}