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
            List<string> startDialogs;
            startDialogs = new List<string> {
                "",
                "触发剧情3a：负责给糖果施展开心魔法的精灵厌恶精灵王国必须要上进和开心的氛围，它想要体验悲伤和愤怒。因为这个原因他没办法再制造开心的糖果"
            };
            dm.ShowDialog(startDialogs);
        }
    }
}
