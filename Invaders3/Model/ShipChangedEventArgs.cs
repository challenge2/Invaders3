using System;

namespace Invaders3.Model
{
    class ShipChangedEventArgs : EventArgs
    {
        public Ship ShipUpdated { get; private set; }
        public bool Killed { get; private set; }

        public ShipChangedEventArgs(Ship shipUpdated, bool killed)
        {
            ShipUpdated = shipUpdated;
            Killed = killed;
        }
    }
}
