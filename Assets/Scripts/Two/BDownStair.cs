using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BDownStair : MonoBehaviour
{
    public bool isFunc = true;

    public void trigger(STManager sm)
    {
        dialogUI dm = sm.DialogUI.GetComponent<dialogUI>();
        if (dm != null)
        {
            if(sm.table1 && sm.knight && sm.grandma && sm.kingtable && sm.king && sm.mary && sm.people)
            {
                sm.step3();
            }
            else
            {
                List<DialogData> startDialogs;
                startDialogs = new List<DialogData> {
                    new DialogData("", null, 0, null, 0),
                    new DialogData("----再去找人聊一聊把----", null, 0.65f, null, 0.74f),
                };
                dm.ShowDialog(startDialogs);
            }
        }
    }
}
