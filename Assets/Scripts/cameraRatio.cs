using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRatio : MonoBehaviour
{
    private float targetAspect = 16f / 9f;  // 目标宽高比
    
    private void Start()
    {
        SetCameraAspectRatio();
    }
    
    private void SetCameraAspectRatio()
    {
        Camera cam = GetComponent<Camera>();
        float windowAspect = (float)Screen.width / (float)Screen.height;
        float scaleHeight = windowAspect / targetAspect;
        
        Rect rect = cam.rect;
        
        if (scaleHeight < 1.0f)  // 屏幕比例更"宽"，需要上下黑条
        {
            rect.width = 1.0f;
            rect.height = scaleHeight;
            rect.x = 0;
            rect.y = (1.0f - scaleHeight) / 2.0f;
        }
        else  // 屏幕比例更"窄"，需要左右黑条
        {
            float scaleWidth = 1.0f / scaleHeight;
            rect.width = scaleWidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scaleWidth) / 2.0f;
            rect.y = 0;
        }
        
        cam.rect = rect;
    }
}
