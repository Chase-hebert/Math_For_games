using System.Numerics;

namespace MathLibrary
{
    public struct Vector2
    {
        private float _x;
        private float _y;

        public float X { get => _x; set { value = _x; } }
        public float Y { get => _y; set { value = _y; } }
        public float Magnitude
        {
            get
            {
                return (float)Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            }
        }
        public Vector2 Normalized 
        {
            get
            {
            return this / Magnitude;
            }
        }

       

        public Vector2(float x = 0, float y = 0)
        {
            x = X;
            y = Y;
        }

        public Vector2 Normalize()
        {
            this = Normalized;
            return this;
        }

        

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }

        public float DotProduct(Vector2 other)
        {
            return (X * other.X) + (Y * other.Y);
        }

        public float Distance(Vector2 other)
        {
            return (other - this).Magnitude;
        }
        public static bool operator ==(Vector2 lhs, Vector2 rhs)
        {
            return (lhs.X == rhs.X) && (lhs.Y == rhs.Y);
        }
        public static bool operator !=(Vector2 lhs, Vector2 rhs)
        {
            return !(lhs == rhs);
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.X + rhs.X, lhs.Y + rhs.Y);
        }
        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }
        public static Vector2 operator *(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.X * scalar, lhs.Y * scalar);
        }
        public static Vector2 operator /(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.X / scalar, lhs.Y / scalar);
        }

        public static implicit operator Vector2(System.Numerics.Vector2 vector)
        {
            return new Vector2(vector.X, vector.Y);
        }
        public static implicit operator System.Numerics.Vector2(Vector2 vector)
        {
            return new System.Numerics.Vector2(vector.X, vector.Y);
        }
    }
}
