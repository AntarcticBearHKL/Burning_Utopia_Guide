using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePoint : MonoBehaviour
{
    public SceneManager sm;
    private GameObject sprite1;
    private GameObject sprite2;

    void Start()
    {
        if (transform.childCount >= 2)
        {
            sprite1 = transform.GetChild(0).gameObject;
            sprite2 = transform.GetChild(1).gameObject;
        }

        if (sprite1 != null)
        {
            sprite1.SetActive(true);
        }
        if (sprite2 != null)
        {
            sprite2.SetActive(false);
        }
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (sm != null)
        {
            sm.UpdatePosition(gameObject);
        }
        Move();
    }

    public void Move()
    {
        if (sprite1 != null)
        {
            sprite1.SetActive(false);
        }
        if (sprite2 != null)
        {
            sprite2.SetActive(true);
        }
    }

    public void Leave()
    {
        if (sprite1 != null)
        {
            sprite1.SetActive(true);
        }
        if (sprite2 != null)
        {
            sprite2.SetActive(false);
        }
    }
}
