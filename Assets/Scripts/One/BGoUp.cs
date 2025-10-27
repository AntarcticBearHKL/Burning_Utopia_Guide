using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGoUp : MonoBehaviour
{
    public SceneManager sm;

    void OnMouseDown()
    {
        if (sm != null && sm.cameraController != null)
        {
            CameraController controller = sm.cameraController.GetComponent<CameraController>();
            if (controller != null)
            {
                controller.SetPositionY2();
            }
        }
    }
}
