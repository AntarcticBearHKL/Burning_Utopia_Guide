using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGate : MonoBehaviour
{
    public bool isFunc = true;

    public void trigger(SceneManager sm)
    {
        dialogManager dm = sm.dialogManager.GetComponent<dialogManager>();
        if (dm != null)
        {
            List<string> startDialogs;
            if (sm.finalGateOpen)
            {
                startDialogs = new List<string> {
                    "",
                    "得到魔法糖果后，离开进入下一关"
                };
            }
            else
            {
                startDialogs = new List<string> {
                    "",
                    "还不能出去，要得到精灵的魔法"
                };
            }
            dm.ShowDialog(startDialogs);
        }
    }
}
