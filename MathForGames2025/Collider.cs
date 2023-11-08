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

        /// <summary>
        /// The actor this collider is attached to.
        /// </summary>
        public Actor Owner
        {
            get { return _owner; }
        }
        /// <summary>
        /// The number that represents this type of collider.
        /// </summary>
        public int ColliderId
        {
            get {return _colliderId; }
        }
        public Collider(int colliderId, Actor owner)
        {
            _colliderId = colliderId;
            _owner = owner;
        }
        /// <summary>
        /// Choose the appropriate collision detection method based on the collider passed in.
        /// </summary>
        /// <param name="collider">The collider of the actor to check collision against.</param>
        /// <returns>Whether or not these two colliders are overlapping.</returns>
        public bool CheckCollison(Collider collider)
        {
            if (collider.ColliderId == 0)
            {
                CircleCollider circleCollider = (CircleCollider)collider;
                return CheckCollisionCircle(circleCollider);
            }

            return false;   
        }


        public virtual bool CheckCollisionCircle(CircleCollider collider)
        {
            return false;
        }
        public virtual void Draw() 
        {

        }
    }
}
