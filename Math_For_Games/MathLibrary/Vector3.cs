using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    internal struct Vector3
    {
        private float _x;
        private float _y;
        private float _z;

        public float X { get => _x; set { value = _x; } }
        public float Y { get => _y; set { value = _y; } }
        public float Z { get => _z; set { value = _z; } }

        public float Magnitude
        {
            get
            {
                return (float)Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
            }
        }
        public Vector3 Normalized
        {
            get
            {
                return this / Magnitude;
            }
        }

        public Vector3(float x = 0, float y = 0, float z = 0)
        {
            x = X;
            y = Y;
            z = Z;
        }

        public Vector3 Normalize()
        {
            this = Normalized;
            return this;
        }

       public float DotProduct(Vector3 other)
        {
            return (X * other.X) + (Y * other.Y) + (Z * other.Z);
        }

        public float Distance(Vector3 other)
        {
            return (other - this).Magnitude;
        }

        public float V3CrossProduct(Vector3 a, Vector3 b)
        {
            return ((a.Y * b.Z) - (a.Z * b.Y)) + ((a.Z * b.X) - (a.X * b.Z)) + ((a.X * b.Y) - (a.Y * b.X));    
        }

        public static bool operator ==(Vector3 left, Vector3 right)
        {
            return (left.X == right.X) && (left.Y == right.Y) && (left.Z == right.Z);
        }
        
        public static bool operator !=(Vector3 left, Vector3 right)
        {
            return !(left == right);
        }

        public static Vector3 operator +(Vector3 left, Vector3 right)
        {
            return new Vector3(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        public static Vector3 operator -(Vector3 left, Vector3 right)
        {
            return new Vector3(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        public static Vector3 operator *(Vector3 left, float scalar)
        {
            return new Vector3(left.X * scalar, left.Y * scalar, left.Z * scalar);
        }

        public static Vector3 operator /(Vector3 left, float scalar)
        {
            return new Vector3(left.X / scalar, left.Y / scalar, left.Z / scalar);
        }

        public static implicit operator Vector3(System.Numerics.Vector3 vector)
        {
            return new Vector3(vector.X, vector.Y, vector.Z);
        }

        public static implicit operator System.Numerics.Vector3(Vector3 vector)
        {
            return new System.Numerics.Vector3(vector.X, vector.Y, vector.Z);
        }
    }
}
