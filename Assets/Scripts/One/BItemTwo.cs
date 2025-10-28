using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BItemTwo : MonoBehaviour
{
    public SceneOneManager sm;

    void OnMouseDown()
    {
        if (sm != null && sm.fruitClickble)
        {
            sm.GetItem(2);
            gameObject.SetActive(false);
        }
    }

}
