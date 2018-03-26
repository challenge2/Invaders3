using System;
using System.Windows;

namespace Invaders3.Model
{
    class Shot {
    public const double ShotPixelsPerSecond = 95;

    public Point Location { get; private set; }
    public static Size ShotSize = new Size(2, 10); // TODO: will need to be a property to scale

    // private Direction _direction;
    public Direction Direction { get; private set; }

    private DateTime _lastMoved;

    public Shot(Point location, Direction direction)
    {
        Location = location;
        Direction = direction;

        _lastMoved = DateTime.Now;
    }

    public void Move()
    {
        TimeSpan timeSinceLastMoved = DateTime.Now - _lastMoved;
        double distance = timeSinceLastMoved.Milliseconds * ShotPixelsPerSecond / 1000;

        if (Direction == Direction.Up) distance *= -1;
        Location = new Point(Location.X, Location.Y + distance);
        _lastMoved = DateTime.Now;
    }
  }
}
