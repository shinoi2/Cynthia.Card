using System;

namespace Cynthia.Card.Server
{
    public class GwentRoom
    {
        public ClientPlayer Player1 { get; set; }
        public ClientPlayer Player2 { get; set; }
        public GwentServerGame CurrentGame { get; set; }
        public bool IsReady { get => Player2 != null && Player1 != null; }

        public GwentRoom(ClientPlayer player)
        {
            Player1 = player;
        }
        public bool AddPlayer(ClientPlayer player)
        {
            if (Player1 == null)
            {
                Player1 = player;
                return true;
            }
            if (Player2 == null)
            {
                Player2 = player;
                return true;
            }
            return false;
        }
    }
}