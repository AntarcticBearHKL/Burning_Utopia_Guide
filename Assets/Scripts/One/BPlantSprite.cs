using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPlantSprite : MonoBehaviour
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
                "神树的果实是制作糖果的原料，它会结好几种不同的果实，大部分精灵都住在神树里",
                "精灵会将部分果实用于播种，希望能培养出神奇的植物，做更多味道的糖果。它们最近培育出了一种特别的鲜花。提醒你可以采集试一试",
            };
            dm.ShowDialog(startDialogs);
        }
    }
}
