using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject currentPosition;
    public GameObject dialogManager;
    public CameraController cameraController;
    public GameObject uiManager;

    public bool finalGateOpen = false;

    void Start()
    {
        if (dialogManager != null)
        {
            dialogManager dm = dialogManager.GetComponent<dialogManager>();
            if (dm != null)
            {
                List<string> startDialogs = new List<string> { 
                    "我是勇者，要得到精灵的魔法，救出公主", 
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

    public bool IsDialogActive()
    {
        if (dialogManager != null)
        {
            dialogManager dm = dialogManager.GetComponent<dialogManager>();
            if (dm != null)
            {
                return dm.IsDialogActive();
            }
        }
        return false;
    }
}
