using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Raylib_cs;

namespace MathForGames2025
{
    internal class Player : Actor
    {

        //char input = Console.ReadKey(true).KeyChar;
        
            
        public override void Update()
        {
            PlayerMovementorSomeShit();
           
        }
        public Player(Icon icon, Vector2 position):base (icon, position){}
        public void PlayerMovementorSomeShit()
        {

            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                Position += new Vector2(0, -1);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                Position += new Vector2(-1, 0);

            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                Position += new Vector2(0, 1);

            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                Position += new Vector2(1, 0);
            }

            
        }

    }
}
