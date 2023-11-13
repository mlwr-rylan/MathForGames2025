using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Raylib_cs;
using System.Reflection.Metadata.Ecma335;
using System.Buffers.Text;

namespace MathForGames2025
{
    internal class Player : Character
    {
        private float _speed = 50.0f;
        private Vector2 Velocity; // Define Velocity as a class member

        public Player(Icon icon, Vector2 position) : base(icon, position) { }

        public Player(string spritePath, Vector2 position) : base(spritePath, position) { }

        public override void Update(float deltaTime)
        {
            PlayerMovement(deltaTime);
        }

        public void PlayerMovement(float deltaTime)
        {
            Vector2 direction = new Vector2();

            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                direction += new Vector2(0, -1);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                direction += new Vector2(-1, 0);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                direction += new Vector2(0, 1);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                direction += new Vector2(1, 0);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT_SHIFT))
            {
                _speed = 200f;
            }
            else
            {
                _speed = 100f;
            }
            // Normalize the direction to ensure consistent speed in all directions
            Velocity = direction.GetNormalized() * _speed;

            if (LocalPosition.X >= 800)
            {
                LocalPosition = new Vector2(0, LocalPosition.Y);
            }
            if(LocalPosition.Y >= 450)
            {
                LocalPosition = new Vector2(LocalPosition.X, 0);

            }
            // Adjust the speed based on deltaTime
            float speed = 200.0f; // Adjust the speed as needed

            // Update the player's position using the velocity
            Velocity = direction * speed;
            LocalPosition += Velocity * deltaTime;
        }
    }
}