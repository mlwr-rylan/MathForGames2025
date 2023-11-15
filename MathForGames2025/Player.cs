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
        private float _speed = 100.0f; // Default speed
        private Vector2 Velocity; // Define Velocity as a class member

        public Player(Icon icon, Vector2 position) : base(icon, position) { }

        public Player(string spritePath, Vector2 position) : base(spritePath, position) { }

        public override void Update(float deltaTime)
        {
            PlayerMovement(deltaTime);
            // Update the player's position using the velocity
            LocalPosition += Velocity * deltaTime;
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
                _speed = 200f; // Sprinting speed
            }
            else
            {
                _speed = 100f; // Default speed
            }

            // Normalize the direction to ensure consistent speed in all directions
            Velocity = direction.GetNormalized() * _speed;

            // Wrap the player around the screen instead of resetting position
            LocalPosition = new Vector2((LocalPosition.X + 800) % 800, (LocalPosition.Y + 450) % 450);
        }
    }
}
