using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public struct Vector2
    {
        public float x;
        public float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        //Deze was eerst niet static?
        public static float Magnitude(Vector2 v1, Vector2 v2)
        {
            float mag = (((v1.x - v2.x) * (v1.x - v2.x) + (v1.y - v2.y) * (v1.y - v2.y)));
            float magnitude = (float)Math.Sqrt(mag);
            return magnitude;
        }
        //Deze was eerst ook niet static
        public static Vector2 Normalized(Vector2 v1)
        {
            float vMag = Vector2.Magnitude(v1, new Vector2(0, 0));
            Vector2 normalizedVector = new Vector2(v1.x/vMag, v1.y/vMag);
            return normalizedVector;
        }

        public static float Dot(Vector2 lhs, Vector2 rhs)
        {
            float dot = (lhs.x * rhs.x) + (lhs.y * rhs.y);
            return dot;
        }

        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            float rc = ((a.y - b.y) / (a.x - b.x));
            float c = a.y - (a.x * rc);
            float vY = (rc * t) + c;
            Vector2 lerpVector = new Vector2(vY, t);
            return lerpVector;
        }

        public static float Angle(Vector2 lhs, Vector2 rhs)
        {
            float ax = (lhs.x - rhs.x);
            float ay = (lhs.y - rhs.y);
            float angle = (float)Math.Atan2(ay, ax);
            return angle;
        }

        public static Vector2 DirectionFromAngle(float angle)
        {
            throw new NotImplementedException();
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            throw new NotImplementedException();
        }

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            throw new NotImplementedException();
        }

        public static Vector2 operator -(Vector2 v)
        {
            throw new NotImplementedException();
        }

        public static Vector2 operator *(Vector2 lhs, float scalar)
        {
            throw new NotImplementedException();
        }

        public static Vector2 operator /(Vector2 lhs, float scalar)
        {
            throw new NotImplementedException();
        }
    }
}
