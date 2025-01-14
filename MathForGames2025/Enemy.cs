﻿using System;
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
        
        public Enemy(Character target, Icon icon, Vector2 position) : base( icon, position)
        {
            _target = target;
        }
        //new
        public Enemy(Character target, Icon icon, Vector2 position, float distance, float angle) : base(icon, position)
        {
            _distance = distance;
            _angle = angle;
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
            Icon newIcon = ActorIcon;

            newIcon.IconColor = Color.YELLOW;
                

            if(dotProduct <= 0)
            {
                return;
            }

            newIcon.IconColor = Color.RED;
            ActorIcon = newIcon;
            base.Update(deltaTime);
        }
        public override void Draw()
        {
            Vector2 endPosition = LocalPosition + (Facing * 3);

            Raylib.DrawLine((int)LocalPosition.X, (int)LocalPosition.Y, (int)endPosition.X, (int)endPosition.Y, ActorIcon.IconColor);
            base.Draw();
        }
    }
}
