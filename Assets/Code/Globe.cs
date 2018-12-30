using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Globe : MonoBehaviour {
    public float rotationSpeed;

    public List<Tile> tiles = new List<Tile>();

    private Vector3 previousMousePosition = Vector3.zero;

    bool getIsFacingForward() {
        Vector3 eastPole = transform.rotation * Vector3.right;
        Vector3 northPole = transform.rotation * Vector3.up;
        float yAngle = Vector3.SignedAngle(Vector3.right, eastPole, northPole);
        return Mathf.Abs(yAngle) < 90;
    }

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

    void limitRotation() {
        Vector3 northPole = transform.rotation * Vector3.up;
        Vector3 axis = Vector3.Cross(northPole, Vector3.up);
        float angle = Vector3.SignedAngle(Vector3.up, northPole, axis);
        float absAngle = Mathf.Abs(angle);
        
        if (absAngle > 30) {
            float newAngle = angle < 0 ? -30 : 30;
            float angleChange = newAngle - angle;
            transform.Rotate(axis, angleChange);
        }
    }

    void Update() {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 mousePositionChange = mousePosition - previousMousePosition;

        bool mouseIsClicked = Input.GetMouseButton(0);

        if (mouseIsClicked) {
            Debug.Log(mouseIsClicked);
            bool isFacingForward = getIsFacingForward();
            
            float verticalMousePositionChange = Vector3.Dot(mousePositionChange, Camera.main.transform.up);
            float latitudeDiff = verticalMousePositionChange * rotationSpeed;
            // Vector3 eastPole = transform.rotation * Vector3.right;
            // transform.Rotate(eastPole, isFacingForward ? latitudeDiff : -latitudeDiff, Space.World);
            transform.Rotate(Camera.main.transform.right, verticalMousePositionChange * rotationSpeed, Space.World);

            float horizontalMousePositionChange = Vector3.Dot(mousePositionChange, Camera.main.transform.right);
            float longitudeDiff =  -horizontalMousePositionChange * rotationSpeed;
            // Vector3 northPole = transform.rotation * Vector3.up;
            // transform.Rotate(northPole, longitudeDiff, Space.World);
            transform.Rotate(Vector3.up, -horizontalMousePositionChange * rotationSpeed, Space.World);

            // limitRotation();
        }

        previousMousePosition = mousePosition;
    }
}
