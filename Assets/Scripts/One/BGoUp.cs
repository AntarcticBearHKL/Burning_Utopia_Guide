using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGoUp : MonoBehaviour
{
    public SceneOneManager sm;

    void OnMouseDown()
    {
        if (sm != null && sm.mainCamera != null)
        {
            CameraController controller = sm.mainCamera.GetComponent<CameraController>();
            if (controller != null)
            {
                controller.SetPositionY2();
            }
        }
    }
}
