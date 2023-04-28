using System;

namespace XGame.Dominiam.Entities
{
    public class GamePlatform
    {

        public Guid Id { get; set; }

        public  Game Game { get; set; }
        public Platform Platform { get; set; }
        public DateTime Data { get; set; }
    }
}
