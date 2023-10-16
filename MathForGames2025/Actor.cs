using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using MathLibrary;


namespace MathForGames2025
{
    internal class Actor
    {
        private char _icon;
        private Vector2 _position;

        

        public Actor(char icon, Vector2 position)
        {
            _icon = icon;
            _position = position;

        }
        public Vector2 Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public virtual void Start()
        {

        }

        public virtual void Update()
        {
            Vector2 velocity = new Vector2(1, 0);
            _position = _position + velocity;
        }

        public virtual void Draw()
        {
            Engine.Render(_icon, _position);
        }

        public virtual void End()
        {

        }
    }
}
