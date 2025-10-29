using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BNextGarden : MonoBehaviour
{
    public bool isFunc = true;

    public void trigger(STManager sm)
    {
        dialogUI dm = sm.DialogUI.GetComponent<dialogUI>();
        if (dm != null)
        {
            if(true)
            {
                sm.step4();
            }
            else
            {
                List<DialogData> startDialogs;
                startDialogs = new List<DialogData> {
                    new DialogData("", null, 0, null, 0),
                    new DialogData("", null, 0.65f, null, 0.74f),
                };
                dm.ShowDialog(startDialogs);
            }
        }
    }
}
