using System.Drawing;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace MathLibrary
{
    public struct Vector2
    {
        private float _x;
        private float _y;

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }
        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public Vector2(float x, float y)
        {
            _x = x;
            _y = y;
        }
        public float GetMagnitude()
        {
           
            return (float) MathF.Sqrt(X * X + Y * Y);
        }
        public static float DotProduct(Vector2 a, Vector2 b)
        {
            return (float)a.X * b.X + a.Y * b.Y;
        }
        public static float GetDistance(Vector2 a, Vector2 b)
        {
            return (a - b).GetMagnitude();
        }
 
        // makes vectors length one
        public void Normalize()
        {
            
            float magnitude = GetMagnitude();
            
            if(magnitude == 0)
            {
                return;
            }
            X /= magnitude;
            Y /= magnitude;
            // velocity.Normalize() - will change velocity to be a unit vector.
            // velocity.GetNormalized() - will return a new normalized vector without changing velocity.
        }
        //divide the vector by its magnitude to get a value of 1
        public Vector2 GetNormalized()
        {
            float magnitude = GetMagnitude();

            if (magnitude == 0)
            {
                return new Vector2();
            }
            return new Vector2(X / magnitude, Y / magnitude);
            

           
        }
        public static Vector2 operator + (Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.X + rhs.X, lhs.Y + rhs.Y);
        }
        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }
        public static Vector2 operator *(Vector2 lhs, float Scalar)
        {
            return new Vector2(lhs.X * Scalar, lhs.Y * Scalar);
        }
        public static Vector2 operator /(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.X / rhs.X, lhs.Y / rhs.Y);
        }
        
        
        
    }
}