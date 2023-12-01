using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Vector3
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
        
            public Vector3(float x, float y, float z)
            {
                _x = x;
                _y = y;
                _z = z;
            }
        public float GetMagnitude()
        {
            return (float)MathF.Sqrt(X * X + Y * Y + Z * Z );
        }
        public static float DotProduct(Vector3 a, Vector3 b)
            {
                return (float)a.X * b.X + a.Y * b.Y + a.Z * b.Z;
            }
            public static float GetDistance(Vector3 a, Vector3 b)
            {
                return (a - b).GetMagnitude();
            }
            public static Vector3 CrossProduct(Vector3 a, Vector3 b)
            {
                float resultX = a.Y * b.Z - a.Z * b.Y;
                float resultY = a.Z * b.X - a.X * b.Z;
                float resultZ = a.X * b.Y - a.Y * b.X;

                return new Vector3(resultX, resultY, resultZ);
            }
        // makes vectors length one
        public void Normalize()
        {
            float magnitude = GetMagnitude();

            if (magnitude == 0)
            {
                // To avoid division by zero, do nothing if the magnitude is zero
                return;
            }

            // Normalize the vector in-place
            X /= magnitude;
            Y /= magnitude;
            Z /= magnitude;
        }

        public Vector3 GetNormalized()
        {
            float magnitude = GetMagnitude();
            if (magnitude == 0)
            {
                // Handle the case where the vector is already a zero vector or very close to it.
                return new Vector3();
            }

            return new Vector3(X / magnitude, Y / magnitude, Z / magnitude);
        }


        //divide the vector by its magnitude to get a value of 1

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
            {
                return new Vector3(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
            }
            public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
            {
                return new Vector3(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
            }
            public static Vector3 operator *(Vector3 lhs, float Scalar)
            {
                return new Vector3(lhs.X * Scalar, lhs.Y * Scalar, lhs.Z * Scalar);
            }
            public static Vector3 operator /(Vector3 lhs, Vector3 rhs)
            {
                return new Vector3(lhs.X / rhs.X, lhs.Y / rhs.Y, lhs.Z/rhs.Z);
            }
            public static Vector3 operator *(float Scalar, Vector3 lhs )
            {
                return new Vector3(lhs.X * Scalar, lhs.Y * Scalar, lhs.Z * Scalar);
            }



    }
}
