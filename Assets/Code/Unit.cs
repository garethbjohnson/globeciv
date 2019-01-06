using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Unit : MonoBehaviour {
    public Globe globe;
    public float hoverMultiplier = 1.1f;
    public int tileIndex = 0;

    Tile tile;

    Vector3 getPosition() {
        return hoverMultiplier * getTilePosition();
    }

    Vector3 getTilePosition() {
        return globe.transform.rotation * tile.center;
    }

    void moveToMousePosition() {
        Vector3? mousePositionOnGlobe = globe.getMousePositionOnShell();

        if (mousePositionOnGlobe == null) {
            return;
        }

        float shortestDistance = Mathf.Infinity;
        Tile closestTile = globe.tiles[0];

        for (int index = 0; index < globe.tiles.Count; index += 1) {
            Tile currentTile = globe.tiles[index];
            Vector3 tilePosition = globe.transform.rotation * currentTile.center;
            float distance = Vector3.Distance(tilePosition, (Vector3) mousePositionOnGlobe);

            if (distance < shortestDistance) {
                shortestDistance = distance;
                closestTile = currentTile;
            }
        }

        tile = closestTile;
    }

    void Awake() {
        globe = GlobeUtils.getGlobe();
    }

    void Start() {
        tile = globe.tiles[tileIndex];
    }

    void Update() {
        bool mouseWasRightClicked = Input.GetMouseButtonDown(1);

        if (mouseWasRightClicked) {
            moveToMousePosition();
        }

        transform.position = getPosition();
        transform.rotation = globe.transform.rotation * Quaternion.LookRotation(tile.center);
    }
}
