using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Raylib_cs;
using System.Reflection.Metadata.Ecma335;

namespace MathForGames2025
{
    internal class Player : Character
    {

        //char input = Console.ReadKey(true).KeyChar;
        private float _Speed =  50.0f;
        

       

            
        public override void Update(float deltaTime)
        {
            PlayerMovementorSomeShit(deltaTime);
           
        }
        public Player(Icon icon, Vector2 position):base (icon, position){}
        public void PlayerMovementorSomeShit(float deltaTime)
        {
            Vector2 direction = new Vector2();

            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                Position += new Vector2(0, -5);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                Position += new Vector2(-5, 0);

            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                Position += new Vector2(0, 5);

            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                Position += new Vector2(5, 0);
            }

            Velocity = direction.GetNormalized() * _Speed;
            Position += Velocity * deltaTime;
            Velocity = direction * _Speed;
        }

    }
}
