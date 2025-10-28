using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGate : MonoBehaviour
{
    public bool isFunc = true;

    public void trigger(SceneOneManager sm)
    {
        dialogUI dm = sm.dialogUI.GetComponent<dialogUI>();
        if (dm != null)
        {
            List<DialogData> startDialogs;
            if (sm.finalGateOpen)
            {
                startDialogs = new List<DialogData> {
                    new DialogData("", null, 0, null, 0),
                    new DialogData("", null, 0, null, 0),
                };
            }
            else
            {
                startDialogs = new List<DialogData> {
                    new DialogData("", null, 0, null, 0),
                    new DialogData("", null, 0, null, 0),
                };
            }
            dm.ShowDialog(startDialogs);
        }
    }
}
