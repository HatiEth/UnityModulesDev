using UnityEngine;
using System.Collections;

[RequireComponent(typeof(LineRenderer))]
public class DataLineVisualizer : DataVisualizer
{
    public float TotalLineLength = 10f;
    public float MaxHeight = 1f;

    private LineRenderer lineRenderer;

    void Awake()
    {
        base.Awake();
        lineRenderer = GetComponent<LineRenderer>();

        lineRenderer.SetVertexCount(_Provider.LevelOfDetail);
    }

    void Update()
    {
        for (int i = 0; i < _Provider.LevelOfDetail; ++i)
        {
            lineRenderer.SetPosition(i, new Vector3((TotalLineLength / _Provider.LevelOfDetail) * i, (float)_Provider.Get(i) / MaxHeight));
        }
    }
}
