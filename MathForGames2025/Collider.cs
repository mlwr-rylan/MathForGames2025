using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    internal class Collider
    {
        private int _colliderId;
        private Actor _owner;

        public Actor Owner
        {
            get { return _owner; }
        }
        public int ColliderId
        {
            get {return _colliderId; }
        }
        public Collider(int colliderId, Actor owner)
        {
            _colliderId = colliderId;
            _owner = owner;
        }
        public bool CheckCollison(Collider collider)
        {
            if (collider.ColliderId == 0)
            {
                CircleCollider circleCollider = {CircleCollider}collider;
                return CheckCollisionCircle(CircleCollider);
            }
             return false;   
        }


        public bool CheckCollisionCircle(Collider collider)
        {
            return;
        }
    }
}
