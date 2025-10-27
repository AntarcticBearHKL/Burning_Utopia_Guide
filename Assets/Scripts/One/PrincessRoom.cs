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
                List<string> startDialogs;
                startDialogs = new List<string> {
                    "",
                    "扔向公主房间的窗户"
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
