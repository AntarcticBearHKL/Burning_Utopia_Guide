using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessRoom : MonoBehaviour
{
    public SceneOneManager sm;

    public Sprite speo;
    public Sprite spec;


    void OnMouseDown()
    {
        dialogUI dm = sm.dialogUI.GetComponent<dialogUI>();
        if (dm != null)
        {
            if(sm.i1g && sm.itemChoose == 1)
            {
                List<DialogData> startDialogs;
                startDialogs = new List<DialogData> {
                    new DialogData("", null, 0, null, 0),
                    new DialogData("----果子砸向了公主的窗户----", null, 0, null, 0),
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
