using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSwitchPoint : MonoBehaviour
{
    public SceneOneManager sm;
    public int functionIndex;

    void OnMouseDown()
    {
        if (sm != null && sm.mainCamera != null)
        {
            CameraController controller = sm.mainCamera.GetComponent<CameraController>();
            if (controller != null)
            {

                switch (functionIndex)
                {
                    case 1:
                        controller.SetPositionY1();
                        break;
                    case 2:
                        controller.SetPositionY2();
                        break;
                    case 3:
                        controller.SetPositionY3();
                        break;
                }
            }
        }
    }
}
