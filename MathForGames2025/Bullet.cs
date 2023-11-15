using MathLibrary;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    internal class Bullet : Actor 
    {
        private Actor _owner;
        private Vector2 _velocity;
        private float _damage;

        public Bullet(string spritePath, Vector2 position, Actor owner, Vector2 velocity) : base(spritePath, position)
        {
            _owner = owner;
            _velocity = velocity;
        }
        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            LocalPosition += _velocity * deltaTime;
        }
    }
}
