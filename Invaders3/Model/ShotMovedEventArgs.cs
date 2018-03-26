using System;

namespace Invaders3.Model
{
    class ShotMovedEventArgs : EventArgs
    {
        public Shot Shot { get; private set; }
        public bool Disappeared { get; private set; }

        public ShotMovedEventArgs(Shot shot, bool disappeared)
        {
            Shot = shot;
            Disappeared = disappeared;
        }
    }
}
