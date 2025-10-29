using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackManagerInit : MonoBehaviour
{
    public GameObject BlackUI;

    void Start()
    {
        if (BlackUI != null)
        {
            BlackUI blackUIComponent = BlackUI.GetComponent<BlackUI>();
            if (blackUIComponent != null)
            {
                List<string> contents = new List<string> { 
                    "hello", "world" 
                };
                blackUIComponent.ShowContent(contents, "Desktop");
            }
        }
    }
}
