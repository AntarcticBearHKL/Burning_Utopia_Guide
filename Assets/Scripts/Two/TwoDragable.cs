using UnityEngine;

public class TwoDragable : MonoBehaviour
{
    private bool isDragging = false;
    private float offsetY;
    private Camera mainCamera;
    
    public float minY = -5f;
    public float maxY = 5f;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            float newY = mousePosition.y - offsetY;
            newY = Mathf.Clamp(newY, minY, maxY);
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
    }

    void OnMouseDown()
    {
        isDragging = true;
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        offsetY = mousePosition.y - transform.position.y;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }
}
