using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BKingQueen : MonoBehaviour
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
                new DialogData("女儿，该回宴会了，不要让别人觉得王室没有教养", null, 0.65f, spec, 0.74f),
                new DialogData("公主，请回宴会，所有人都在等你", null, 0.65f, spec, 0.74f),
                new DialogData("勇者大人，我先失陪了，请继续在花园休息", null, 0.65f, spec, 0.74f),
            };
            dm.ShowDialog(startDialogs);
        }
    }
}
