using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BStirTwo : MonoBehaviour
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
                "它和负责搅拌糖浆的精灵发生了矛盾，如果能给搅拌糖浆的精灵特别的鲜花新品的话，搅拌糖浆的精灵会很开心，包装的精灵会在你修复流水线后给你有魔法的糖果",
            };
            dm.ShowDialog(startDialogs);
        }
    }
}
