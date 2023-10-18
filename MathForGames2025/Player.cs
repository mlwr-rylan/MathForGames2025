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
        
            
        public override void Update(float deltaTime)
        {
            PlayerMovementorSomeShit(deltaTime);
           
        }
        public Player(Icon icon, Vector2 position):base (icon, position){}
        public void PlayerMovementorSomeShit(float deltaTime)
        {

            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                Position += new Vector2(0, -50) * deltaTime;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                Position += new Vector2(-50, 0) * deltaTime;

            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                Position += new Vector2(0, 50)* deltaTime;

            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                Position += new Vector2(50, 0) * deltaTime;
            }

            
        }

    }
}
