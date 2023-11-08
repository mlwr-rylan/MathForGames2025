﻿using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    internal class Character : Actor
    {

        private Vector2 _velocity;
        public Vector2 Velocity
        {
            get { return _velocity; }
            set { _velocity = value;  }
        }
        public Character (Icon icon, Vector2 position ) : base(icon, position)
        {

        }
        public Character(string spritePath, Vector2 position) : base(spritePath, position)
        {

        }
        public override void Update(float deltaTime)
        {
            LocalPosition += Velocity * deltaTime; 
        }
    }
}
