using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMakeMagic : MonoBehaviour
{
    public bool isFunc = true;

    public void trigger(SceneOneManager sm)
    {
        dialogUI dm = sm.dialogUI.GetComponent<dialogUI>();
        if (dm != null)
        {
            List<DialogData> startDialogs;
            startDialogs = new List<DialogData> {
                new DialogData("", null, 0, null, 0),
                new DialogData("", null, 0, null, 0),
            };
            dm.ShowDialog(startDialogs);
        }
    }
}
