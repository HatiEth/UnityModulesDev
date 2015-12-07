using UnityEngine;
using System.Collections;

public interface IDataVisualizationProvider {
    int LevelOfDetail { get; }

    object Get(int index);

    object this[int index] { get; }
}
