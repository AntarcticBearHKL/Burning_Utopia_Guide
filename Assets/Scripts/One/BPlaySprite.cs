using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPlaySprite : MonoBehaviour
{
    public bool isFunc = true;

    public void trigger(SceneManager sm)
    {
        dialogManager dm = sm.dialogManager.GetComponent<dialogManager>();
        if (dm != null)
        {
            List<string> startDialogs;
            startDialogs = new List<string> {
                "",
                "精灵不会出精灵国，它们的魔法除了附在糖果上，没其它办法带走，但现在它们很久没吃到带快乐魔法的糖果了"
            };
            dm.ShowDialog(startDialogs);
        }
    }
}
