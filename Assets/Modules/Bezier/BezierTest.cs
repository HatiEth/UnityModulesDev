using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class BezierTest : MonoBehaviour {

    [Range(0f, 1f)]
    public float Alpha = 0f;

    public Vector3 p0;
    public Vector3 p1;
    public Vector3 p2;

    public Vector3 p;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        p = BezierCurve.GetPointQuadratic(p0, p1, p2, Alpha);
	}

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(p0, p1);
        Gizmos.DrawLine(p1, p2);

        Gizmos.color = Color.red;
        Gizmos.DrawSphere(p, 0.1f);
    }
}
