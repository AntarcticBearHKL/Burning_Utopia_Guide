using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneOneManager : MonoBehaviour
{
    private GameObject currentPosition;
    public GameObject mainCamera;

    public GameObject dialogUI;
    public GameObject itemUI;

    public bool i1g = false;
    public bool i2g = false;
    public bool i3g = false;
    public bool i4g = false;

    public int itemChoose = -1;

    public bool finalGateOpen = false;

    void Start()
    {
        if (dialogUI != null)
        {
            dialogUI dm = dialogUI.GetComponent<dialogUI>();
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
        if (dialogUI != null)
        {
            dialogUI dm = dialogUI.GetComponent<dialogUI>();
            if (dm != null)
            {
                return dm.IsDialogActive();
            }
        }
        return false;
    }

    public void GetItem(int itemIndex)
    {
        switch (itemIndex)
        {
            case 1:
                i1g = true;
                break;
            case 2:
                i2g = true;
                break;
            case 3:
                i3g = true;
                break;
            case 4:
                i4g = true;
                break;
            default:
                Debug.LogWarning("Invalid item index");
                return;
        }

        if (itemUI != null)
        {
            itemUI ui = itemUI.GetComponent<itemUI>();
            if (ui != null)
            {
                ui.GetF(itemIndex - 1);
            }
        }
    }
}
