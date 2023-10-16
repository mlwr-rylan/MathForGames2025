using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MathForGames2025
{
    internal class Player : Actor
    {   
        
         char input = Console.ReadKey(true).KeyChar;
 
            
        public override void Update()
        {
            
        }
        public Player(char icon, Vector2 position):base (icon, position){}
        public void Up()
        {
            base.Update();

            char direction = Engine.GetInput();

            if (direction == 'w')
            {
                Position += new Vector2(0, -1);
            }
            else if (direction == 's')
            {
                Position += new Vector2(0, 1);

            }
            else if (direction == 'a')
            {
                Position += new Vector2(-1, 0);

            }
            else if (direction == 'd') ;
            {
                Position += new Vector2(1, 0);
            }
        }
        
    }
}
