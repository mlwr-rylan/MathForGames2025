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
            PlayerMovement(deltaTime);
           
        }
        public Player(Icon icon, Vector2 position):base (icon, position){}

        public Player(string spritePath, Vector2 position) : base(spritePath, position) { }
        public void PlayerMovement(float deltaTime)
        {
            Vector2 direction = new Vector2();

            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                LocalPosition += new Vector2(0, -5);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                LocalPosition += new Vector2(-5, 0);

            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                LocalPosition += new Vector2(0, 5);

            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                LocalPosition += new Vector2(5, 0);
            }

            Velocity = direction.GetNormalized() * _Speed;
            LocalPosition += Velocity * deltaTime;
            Velocity = direction * _Speed;
        }

    }
}
