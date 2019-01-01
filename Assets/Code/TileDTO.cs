using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TileDTO {
    public float[] center = new float[3];
    public int id;
    public List<int> neighbors = new List<int>();

    public Tile getTile() {
        return new Tile(center[0], center[1], center[2]);
    }
}
