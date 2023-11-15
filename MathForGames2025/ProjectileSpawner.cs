using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    internal class ProjectileSpawner : Actor
    {
        public ProjectileSpawner(Actor owner, Vector2 position, float projectileSpeed, string projectileSpritePath) : base ("", position)
        {
            _owner = owner;
            Parent = _owner;
            _projectileSpeed = projectileSpeed;
            _projectileSpritePath = projectileSpritePath;
            Engine.AddActorToScene();
        }
    }   
}
