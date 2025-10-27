using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BItemOne : MonoBehaviour
{
    public SceneManager sm;

    void OnMouseDown()
    {
        if (sm != null)
        {
            sm.GetItem(1);
        }

        gameObject.SetActive(false);
    }

}
