using System;
using System.Collections.Generic;
using System.Linq;
using Raylib_cs;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;


namespace MathForGames2025
{  struct Icon
    {

        private string _symbol;
        private Color _color;
        private Vector2 _facing;

        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }
        public Color IconColor
        {
            get { return _color; }
            set { _color = value; }
        }
    }
    
    internal class Actor
    {
        private Icon _icon;
        private Vector2 _position;

        

        public Actor(Icon icon, Vector2 position)
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

        public virtual void Update(float deltaTime)
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
