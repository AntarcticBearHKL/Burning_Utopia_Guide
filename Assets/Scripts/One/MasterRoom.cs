using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterRoom : MonoBehaviour
{
    public SceneOneManager sm;

    public Sprite speo;
    public Sprite spec;

    void OnMouseDown()
    {
        dialogUI dm = sm.dialogUI.GetComponent<dialogUI>();
        if (dm != null)
        {
            if(sm.i1g && sm.itemChoose==1 && sm.princessHitted){
                List<DialogData> startDialogs;
                startDialogs = new List<DialogData> {
                    new DialogData("----族长大发雷霆，施展生气的魔法----", null, 0, spec, 0.74f),
                    new DialogData("公主！你应该把你的吻留在糖果，而不是其它肮脏小精灵的嘴上！", null, 0, spec, 0.74f),
                };
                dm.ShowDialog(startDialogs);
                sm.GetItem(3);
            }
            else if(sm.i1g && sm.itemChoose==1)
            {
                List<DialogData> startDialogs;
                startDialogs = new List<DialogData> {
                    new DialogData("", null, 0, null, 0),
                    new DialogData("----族长骂骂咧咧----", null, 0, spec, 0.74f),
                };
                dm.ShowDialog(startDialogs);
            }
            else
            {

            }
        }
    }
}
