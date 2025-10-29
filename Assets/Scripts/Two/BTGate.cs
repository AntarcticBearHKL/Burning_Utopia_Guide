using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTGate : MonoBehaviour
{
    public bool isFunc = true;

    public void trigger(STManager sm)
    {
        sm.step2();
    }
}
