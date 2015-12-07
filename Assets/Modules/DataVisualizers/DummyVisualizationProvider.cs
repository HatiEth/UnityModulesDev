using UnityEngine;
using System.Collections;
using System;

public class DummyVisualizationProvider : MonoBehaviour, IDataVisualizationProvider {

    public Rigidbody Watchee;

    [SerializeField, ReadOnlyDuringRun]
    private int _LevelOfDetail = 512;

    public int LevelOfDetail
    {
        get { return _LevelOfDetail; }
    }

    public object Get(int index)
    {
        return this[index];
    }

    public object this[int index]
    {
        get { return Values[index]; }
    }

    private float[] Values;

    void Awake()
    {
        Values = new float[LevelOfDetail];
    }

    void LateUpdate()
    {
        Values.ShiftRight();
        Values[0] = Watchee.position.y;
    }
}
