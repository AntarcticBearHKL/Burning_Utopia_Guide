using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject currentPosition;
    public GameObject dialogManager;

    void Start()
    {
        if (dialogManager != null)
        {
            dialogManager dm = dialogManager.GetComponent<dialogManager>();
            if (dm != null)
            {
                List<string> startDialogs = new List<string> { "你好", "世界" };
                dm.ShowDialog(startDialogs);
            }
        }
    }

    void Update()
    {
        
    }

    public void UpdatePosition(GameObject newPosition)
    {
        if (currentPosition == newPosition)
        {
            return;
        }

        if (currentPosition != null)
        {
            movePoint previousPoint = currentPosition.GetComponent<movePoint>();
            if (previousPoint != null)
            {
                previousPoint.Leave();
            }
        }
        currentPosition = newPosition;
    }
}
