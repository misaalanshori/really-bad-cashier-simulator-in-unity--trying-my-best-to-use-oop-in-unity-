using UnityEngine;

public class DraggableObject : MonoBehaviour
{
    private Camera mainCamera;
    private bool isDragging = false;
    private Plane dragPlane;
    private Vector3 offset;

    void Start()
    {
        // Cache the main camera
        mainCamera = Camera.main;
    }

    void OnMouseDown()
    {
        // Create a plane where dragging occurs, parallel to the plane object is on
        dragPlane = new Plane(Vector3.up, transform.position);

        // Raycast from the mouse position to find the hit point on the plane
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (dragPlane.Raycast(ray, out float enter))
        {
            Vector3 hitPoint = ray.GetPoint(enter);
            offset = transform.position - hitPoint;
            isDragging = true;
        }
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            // Update the object's position to follow the mouse
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (dragPlane.Raycast(ray, out float enter))
            {
                Vector3 hitPoint = ray.GetPoint(enter);
                transform.position = hitPoint + offset;
            }
        }
    }

    void OnMouseUp()
    {
        isDragging = false;
    }
}
