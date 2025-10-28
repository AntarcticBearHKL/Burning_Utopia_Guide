using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessRoom : MonoBehaviour
{
    public SceneOneManager sm;

    void OnMouseDown()
    {
        dialogUI dm = sm.dialogUI.GetComponent<dialogUI>();
        if (dm != null)
        {
            if(sm.i1g && sm.itemChoose == 0)
            {
                List<DialogData> startDialogs;
                startDialogs = new List<DialogData> {
                    new DialogData("", null, 0, null, 0),
                    new DialogData("", null, 0, null, 0),
                };
                dm.ShowDialog(startDialogs);
                sm.princessHitted = true;
            }
            else
            {

            }
        }
    }
}
