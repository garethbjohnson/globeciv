using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MainCamera : MonoBehaviour {
    public float maxZoom = 9f;
    public float minZoom = 1f;
    public float rotationSpeed = 20f;
    public float zoom = 5f;
    public float zoomSensitivity = 1f;

    private Globe globe;

    void handleRotate() {
        bool mouseIsClicked = Input.GetMouseButton(0);

        if (mouseIsClicked) {
            float horizontalMousePositionChange = Input.GetAxis("Mouse X");
            float longitudeDiff = -horizontalMousePositionChange * rotationSpeed * zoom / maxZoom;
            transform.RotateAround(Vector3.zero, -transform.up, longitudeDiff);

            float verticalMousePositionChange = Input.GetAxis("Mouse Y");
            float latitudeDiff = verticalMousePositionChange * rotationSpeed * zoom / maxZoom;
            transform.RotateAround(Vector3.zero, -transform.right, latitudeDiff);
        }
    }

    void handleZoom() {
        float zoomDiff = zoomSensitivity * Input.GetAxis("Mouse ScrollWheel");
        zoom = Mathf.Clamp(zoom + zoomDiff, minZoom, maxZoom);
        Camera.main.orthographicSize = zoom;
    }

    void Awake() {
        globe = GlobeUtils.getGlobe();
    }

    void Update() {
        handleRotate();
        handleZoom();
    }
}
