using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WechatIcon : MonoBehaviour
{
    private float lastClickTime;
    private const float doubleClickThreshold = 0.3f;

    public GameObject UI;

    void Start()
    {
        lastClickTime = 0f;
    }

    void OnMouseDown()
    {
        float timeSinceLastClick = Time.time - lastClickTime;
        if (timeSinceLastClick <= doubleClickThreshold)
        {
            UI.SetActive(true);
        }
        lastClickTime = Time.time;
    }
}
