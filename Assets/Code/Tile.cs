using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {
    public List<Tile> neighbors = new List<Tile>();
    public Vector3 center;

    public Tile(double x, double y, double z) {
        this.center = new Vector3(
            (float) x,
            (float) y,
            (float) z
        );
    }
}
