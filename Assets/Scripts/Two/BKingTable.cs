using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BKingTable : MonoBehaviour
{
    public bool isFunc = true;

    public Sprite speo;
    public Sprite spec;

    public void trigger(STManager sm)
    {
        dialogUI dm = sm.DialogUI.GetComponent<dialogUI>();
        if (dm != null)
        {
            List<DialogData> startDialogs;
            startDialogs = new List<DialogData> {
                new DialogData("", null, 0, null, 0),
                new DialogData("公主又躲到后花园去了，她什么时候才能学会承担公主的责任！", null, 0.65f, spec, 0.74f),
                new DialogData("她的衣食住所无一不来源于您的英明统治，给她时间，她会明白的", null, 0.65f, spec, 0.74f),
                new DialogData("现在，我们先享受宴会，欣赏表演吧", null, 0.65f, spec, 0.74f),
                new DialogData("唉我真不明白，我从小宠着她惯着她，现在只需要她奉献一小下", speo, 0.65f, null, 0.74f),
                new DialogData("那么多人为了梦之国奉献，为什么就她不可以？", null, 0.65f, spec, 0.74f),
            };
            dm.ShowDialog(startDialogs);
            sm.kingtable = true;
        }
    }
}
