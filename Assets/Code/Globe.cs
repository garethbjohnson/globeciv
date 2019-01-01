using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Globe : MonoBehaviour {
    public float maxYAngle = 30f;
    public bool rotationIsLimited = false;
    public float rotationSpeed;

    public List<Tile> tiles = new List<Tile>();

    private Vector3 previousMousePosition = Vector3.zero;

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

    bool getIsBadRotation() {
        if (!rotationIsLimited) {
            return false;
        }

        Vector3 northPole = transform.rotation * Vector3.up;
        Vector3 axis = Vector3.Cross(northPole, Vector3.up);
        float angle = Vector3.SignedAngle(Vector3.up, northPole, axis);
        return Mathf.Abs(angle) > maxYAngle;
    }

    void Update() {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 mousePositionChange = mousePosition - previousMousePosition;

        bool mouseIsClicked = Input.GetMouseButton(0);

        if (mouseIsClicked) {
            Quaternion previousRotation = transform.rotation;

            float verticalMousePositionChange = Vector3.Dot(mousePositionChange, Camera.main.transform.up);
            float latitudeDiff = verticalMousePositionChange * rotationSpeed;
            transform.Rotate(Camera.main.transform.right, latitudeDiff, Space.World);

            float horizontalMousePositionChange = Vector3.Dot(mousePositionChange, Camera.main.transform.right);
            float longitudeDiff =  -horizontalMousePositionChange * rotationSpeed;
            transform.Rotate(Vector3.up, longitudeDiff, Space.World);

            bool isBadRotation = getIsBadRotation();

            if (isBadRotation) {
                transform.rotation = previousRotation;
            }
        }

        previousMousePosition = mousePosition;
    }
}
