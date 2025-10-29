using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BLuxyPri : MonoBehaviour
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
                new DialogData("勇者大人", null, 0, null, 0),
                new DialogData("这是我最喜欢的地方，我喜欢看着月色静静的在莲花上照射出流动的水光", null, 0.65f, spec, 0.74f),
                new DialogData("你好，请问你有看到公主吗？", null, 0.65f, spec, 0.74f),
                new DialogData("您对公主的情感真是令人感动，但很抱歉我无法帮助您", null, 0.65f, spec, 0.74f),
                new DialogData("顺便一说，您这身盔甲很漂亮", speo, 0.65f, null, 0.74f),
                new DialogData("真……真的吗？这是我自己用废弃的材料拼装的，第一次得到专业人士的肯定！", null, 0.65f, spec, 0.74f),
                new DialogData("当然！您直接穿这一身来宴会的勇气，也非常值得肯定", null, 0.65f, spec, 0.74f),
            };
            dm.ShowDialog(startDialogs);
        }
    }
}
