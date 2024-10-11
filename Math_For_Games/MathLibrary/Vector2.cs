namespace MathLibrary
{
    public class Vector2
    {
        private float _x;
        private float _y;

        public float X {get => _x; set { value = _x; } }
        public float Y {get => _y; set { value = _y; } }

        public Vector2(float x, float y)
        {
            x = X;
            y = Y;
        }
    }
}
