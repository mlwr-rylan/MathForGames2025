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
        public float GetMagnitude(float a, float b)
        {
            return MathF.Sqrt(a * a * b * b);
        }

        // makes vectors length one
        
        public void Normalize()
        {
            
            // velocity.Normalize() - will change velocity to be a unit vector.
            // velocity.GetNormalized() - will return a new normalized vector without changing velocity.
        }
        //divide the vector by its magnitude to get a value of 1
        public Vector2 GetNormalized()
        {

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