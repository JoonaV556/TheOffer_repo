using Fusion;
using UnityEngine;

namespace FootBall
{
    public struct NetworkInputData : INetworkInput
    {
        public const byte MOUSEBUTTON0 = 1;

        public Vector3 direction;
        public NetworkButtons buttons;
    }
}
