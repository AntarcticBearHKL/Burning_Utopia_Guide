using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameIcon : MonoBehaviour
{
    private float lastClickTime;
    private const float doubleClickThreshold = 0.3f;

    void Start()
    {
        lastClickTime = 0f;
    }

    void OnMouseDown()
    {
        float timeSinceLastClick = Time.time - lastClickTime;
        if (timeSinceLastClick <= doubleClickThreshold)
        {
            SceneManager.LoadScene("SceneOne");
        }
        lastClickTime = Time.time;
    }
}
