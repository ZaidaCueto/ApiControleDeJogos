using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Dominiam.Entities
{
    public class MyGame
    {
        public Guid Id { get; set; }

        public GamePlatform GamePlatform { get; set; }
        public bool DesiredGame { get; set; }
        public DateTime DateDesired { get; set; }
        public bool Exchange { get; set; }
        public bool Sale { get; set; }


    }
}
