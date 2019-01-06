using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Globe : MonoBehaviour {
    public TextAsset jsonFile;
    public List<Tile> tiles = new List<Tile>();

    public Vector3? getMousePositionOnShell() {
        Ray mousePositionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit[] rayHits = Physics.RaycastAll(mousePositionRay, Mathf.Infinity);

        rayHits = rayHits.Where(hit => hit.collider.gameObject.tag == "GlobeShell").ToArray();

        if (rayHits.Count() == 0) {
            return null;
        }

        float[] distances = rayHits.Select(hit => Vector3.Distance(mousePositionRay.origin, hit.point)).ToArray();
        float shortestDistance = distances.Min();
        int shortestDistanceIndex = Array.IndexOf(distances, shortestDistance);
        RaycastHit closestHit = rayHits[shortestDistanceIndex];
        return closestHit.point;
    }

    void Awake() {
        string json = jsonFile.text;
        GlobeDTO globeDTO = JsonUtility.FromJson<GlobeDTO>(json);
        tiles = globeDTO.getTiles();
    }
}
