using System;
using System.Collections.Generic;
using System.Linq;
using MathLibrary;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    internal class Enemy : Character
    {
        private Character _target;
        public Enemy(Character target, Icon icon, Vector2 position) : base( icon, position)
        {
            _target = target;
        }
        public override void Update(float deltaTime)
        {
            //vector from enenmy to target.
            Vector2 enemyToTarget = _target.Position - Position;

            // normalize the vector
            Vector2 direction = enemyToTarget.GetNormalized();

            //set velocity to be that vector scaled by speed
            Velocity = direction * 100f;

            base.Update(deltaTime);
        }
    }
}
