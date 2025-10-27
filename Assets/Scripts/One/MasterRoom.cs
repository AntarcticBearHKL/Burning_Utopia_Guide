using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterRoom : MonoBehaviour
{
    public SceneOneManager sm;

    void OnMouseDown()
    {
        dialogUI dm = sm.dialogUI.GetComponent<dialogUI>();
        if (dm != null)
        {
            if(sm.i1g && sm.itemChoose==0 && sm.princessHitted){
                List<string> startDialogs;
                startDialogs = new List<string> {
                    "",
                    "触发剧情4b：族长看到公主偷情，大发雷霆，施展生气的魔法",
                    "触发剧情5：魔法降落在施展开心魔法的精灵上，他感受到了愤怒，变得开心，施展了开心魔到糖果上",
                    "触发动画：糖果变得有光泽"
                };
                dm.ShowDialog(startDialogs);
                sm.GetItem(2);
            }
            else if(sm.i1g && sm.itemChoose==0)
            {
                List<string> startDialogs;
                startDialogs = new List<string> {
                    "",
                    "族长骂骂咧咧"
                };
                dm.ShowDialog(startDialogs);
            }
            else
            {

            }
        }
    }
}
