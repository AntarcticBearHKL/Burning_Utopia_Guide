using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragableDancer : MonoBehaviour
{
    public int musicIndex = 1;
    public GameObject musicPlayerGO;
    public GameObject changePositionGO;
    public Vector2 correctPosition;
    private bool isDragging = false;
    private Vector2 originalPosition;

    public bool correct()
    {
        if (Vector2.Distance((Vector2)transform.position, correctPosition) < 0.1f)
        {
            return true;
        }
        return false;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        isDragging = true;
        originalPosition = transform.position;
        musicPlayerGO.GetComponent<musicPlayer>().Play(musicIndex);
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            transform.position = pos;
        }
    }

    void OnMouseUp()
    {
        isDragging = false;
        changePositionGO.GetComponent<changePosition>().HandleDrop(gameObject, (Vector2)transform.position, originalPosition);
        musicPlayerGO.GetComponent<musicPlayer>().Stop();
    }
}
