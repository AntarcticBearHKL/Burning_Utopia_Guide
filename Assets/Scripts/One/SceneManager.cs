using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject currentPosition;
    public GameObject dialogManager;

    private bool finalGoal = false;

    void Start()
    {
        if (dialogManager != null)
        {
            dialogManager dm = dialogManager.GetComponent<dialogManager>();
            if (dm != null)
            {
                List<string> startDialogs = new List<string> { 
                    "国王听说精灵的魔法能长生不老，但精灵除了让人开心，什么也不会", 
                    "公主现在怎么样呢" 
                };
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
