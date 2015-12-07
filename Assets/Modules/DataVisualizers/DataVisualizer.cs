using UnityEngine;
using System.Collections;

public class DataVisualizer : MonoBehaviour {

    protected IDataVisualizationProvider _Provider;

    protected void Awake()
    {
        _Provider = GetComponent<IDataVisualizationProvider>();
        if (_Provider == null)
        {
            throw new System.ArgumentException("DataVisualizer requires a DataVisualizationProvider to work.");
        }
    }

}
