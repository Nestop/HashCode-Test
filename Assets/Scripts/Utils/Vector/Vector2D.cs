﻿namespace Utils
{
    public class Vector2D
    {
       public float x;
       public float y;

       public Vector2D(float x, float y)
       {
           this.x = x;
           this.y = y;
       }

        public override bool Equals(object obj)
        {
            var vector = obj as Vector2D;
            return x == vector.x && y == vector.y;
        }

        public override int GetHashCode()
        {
            int hashcode = x.GetHashCode();
            hashcode = 31*hashcode + y.GetHashCode();
            return hashcode;
        }
    }
}