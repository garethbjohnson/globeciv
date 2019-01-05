using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpaceBackground : MonoBehaviour {
    void Awake()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.triangles = mesh.triangles.Reverse().ToArray();
    }
}
