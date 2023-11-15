﻿using System;
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

                return (float)MathF.Sqrt(X * X + Y * Y + Z * Z);
            }
            public static float DotProduct(Vector3 a, Vector3 b)
            {
                return (float)a.X * b.X + a.Y * b.Y + a.Z * b.Z;
            }
            public static float GetDistance(Vector3 a, Vector3 b)
            {
                return (a - b).GetMagnitude();
            }

            // makes vectors length one
            public void Normalize(Vector3 direction)
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
            public Vector3 GetNormalized()
            {
                float magnitude = GetMagnitude();

                if (magnitude == 0)
                {
                    return new Vector3();
                }
                return new Vector3(X / magnitude, Y / magnitude, Z/ magnitude);



            }
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