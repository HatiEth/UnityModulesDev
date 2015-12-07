using UnityEngine;
using System.Collections;

public class BezierCurve {

    public static Vector3 GetPointQuadratic(Vector3 p0, Vector3 p1, Vector3 p2, float a)
    {
        a = Mathf.Clamp01(a);

        Vector3 arg0 = ((1 - a) * (1 - a)) * p0;
        Vector3 arg1 = (2 * (1 - a) * a) * p1;
        Vector3 arg2 = (a * a) * p2;

        return arg0 + arg1 + arg2;
    }

}
