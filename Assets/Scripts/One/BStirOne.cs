using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BStirOne : MonoBehaviour
{
    public bool isFunc = true;

    public void trigger(SceneOneManager sm)
    {
        dialogUI dm = sm.dialogUI.GetComponent<dialogUI>();
        if (dm != null)
        {
            List<string> startDialogs;
            startDialogs = new List<string> {
                "",
                "糖果没有魔法是因为流水线上负责施展魔法的小精灵总是不快乐，没办法施展快乐魔法",
            };
            dm.ShowDialog(startDialogs);
        }
    }
}
