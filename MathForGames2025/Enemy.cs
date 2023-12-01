using System;
using System.Collections.Generic;
using System.Linq;
using MathLibrary;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using System.Transactions;

namespace MathForGames2025
{
    internal class Enemy : Character
    {
        //new
        private float _distance;
        private float _angle;
        private Character _target;
        private Sprite _sprite;  // Add a Sprite property for the enemy's visual representation

        public Enemy(Character target, string spritePath, Vector2 position) : base(spritePath,position)
        {
            _target = target;
            _sprite = new Sprite(spritePath);
          
           

        }

        //detection 
        public override void Update(float deltaTime)
        {
            //vector from enenmy to target.
            Vector2 enemyToTarget = _target.LocalPosition - LocalPosition;

            // normalize the vector
            Vector2 direction = enemyToTarget.GetNormalized();

            //set velocity to be that vector scaled by speed
            Velocity = direction * 100f;

            float dotProduct = Vector2.DotProduct(direction, Facing);
            //make the enemy yellow when facing me and make him red when im in his view .
            //Icon newIcon = ActorIcon;

            //newIcon.IconColor = Color.YELLOW;
                

            if(dotProduct <= 0)
            {
                return;
            }

            //newIcon.IconColor = Color.RED;
            //ActorIcon = newIcon;
            base.Update(deltaTime);
        }
        public virtual void Draw()
        {

            if (AttachedCollider != null)
                AttachedCollider.Draw();
            if (_sprite != null)
            {
                _sprite.Draw(GlobalTransforms);
            }
        }



    }
}
