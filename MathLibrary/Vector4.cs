using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Vector4
    {
        private float _x;
        private float _y;
        private float _z;

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
        public float Z
        {
            get { return _z; }
            set { _z = value; }
        }

        public Vector4(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
        public float GetMagnitude()
        {

            return (float)MathF.Sqrt(X * X + Y * Y + Z * Z);
        }
        public static float DotProduct(Vector4 a, Vector4 b)
        {
            return (float)a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        public static float GetDistance(Vector4 a, Vector4 b)
        {
            return (a - b).GetMagnitude();
        }

        // makes vectors length one
        public void Normalize(Vector4 direction)
        {

            float magnitude = GetMagnitude();

            if (magnitude == 0)
            {
                return;
            }
            X /= magnitude;
            Y /= magnitude;
            Z /= magnitude;
            // velocity.Normalize() - will change velocity to be a unit vector.
            // velocity.GetNormalized() - will return a new normalized vector without changing velocity.
        }
        //divide the vector by its magnitude to get a value of 1
        public Vector4 GetNormalized()
        {
            float magnitude = GetMagnitude();

            if (magnitude == 0)
            {
                return new Vector4();
            }
            return new Vector4(X / magnitude, Y / magnitude, Z / magnitude);



        }
        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        }
        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        }
        public static Vector4 operator *(Vector4 lhs, float Scalar)
        {
            return new Vector4(lhs.X * Scalar, lhs.Y * Scalar, lhs.Z * Scalar);
        }
        public static Vector4 operator /(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.X / rhs.X, lhs.Y / rhs.Y, lhs.Z / rhs.Z);
        }
        public static Vector4 operator *(float Scalar, Vector4 lhs)
        {
            return new Vector4(lhs.X * Scalar, lhs.Y * Scalar, lhs.Z * Scalar);
        }




    }
}

