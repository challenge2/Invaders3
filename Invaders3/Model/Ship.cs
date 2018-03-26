using System.Windows;

namespace Invaders3.Model
{
    abstract class Ship
    { 
         public Point Location { get; protected set; }

        public Size Size { get; private set; }

        public Rect Area
        {
            get { return new Rect(Location, Size); }
        }

        public Ship(Point location, Size size)
        {
            Location = location;
            Size = size;
        }

         public abstract void Move(Direction direction);
    }
}
