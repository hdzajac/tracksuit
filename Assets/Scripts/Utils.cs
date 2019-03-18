
    using UnityEngine;

    public class Utils
    {
        public static Quaternion getYAxisRotation(Quaternion q)
        {
            var theta = Mathf.Atan2(q.y, q.w);
            // quaternion representing rotation about the y axis
            return new Quaternion(0, Mathf.Sin(theta), 0, Mathf.Cos(theta));
        }
    }