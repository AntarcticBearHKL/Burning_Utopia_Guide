using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BKing : MonoBehaviour
{
    public bool isFunc = true;

    public Sprite speo;
    public Sprite spec;
    public Sprite other;

    public void trigger(STManager sm)
    {
        dialogUI dm = sm.DialogUI.GetComponent<dialogUI>();
        if (dm != null)
        {
            List<DialogData> startDialogs;
            startDialogs = new List<DialogData> {
                new DialogData("", null, 0, null, 0),
                new DialogData("尊贵的国王陛下，您好，我是桑", speo, 0.65f, null, 0.64f),
                new DialogData("我们王国的英雄！你终于来了！", null, 0.65f, spec, 0.64f),
                new DialogData("说英雄有点言过其实了，我只是运气好，加上，一想到公主就有了坚持下去的勇气", speo, 0.65f, spec, 0.64f),
                new DialogData("桑，是第一次来皇宫吧？", null, 0.65f, other, 0.64f),
                new DialogData("我之前铺砖和砌墙的时候来过！", speo, 0.65f, null, 0.64f),
                new DialogData("呵，你真有趣。你知道，见到国王陛下，要先躬身致意，在陛下没问你名字前，不要说更多的话吗？", null, 0.65f, other, 0.64f),
                new DialogData("对不起国王和王后陛下，我……我一直在找公主殿下，还没来得及学习礼仪", speo, 0.65f, null, 0.64f),
                new DialogData("对于王国的英雄，不用如此苛刻，你想找公主？", null, 0.65f, spec, 0.64f),
                new DialogData("是的，我是为公主而来", speo, 0.65f, null, 0.64f),
                new DialogData("她在后花园，如果你找到她，和她聊聊吧", null, 0.65f, spec, 0.64f),
            };
            dm.ShowDialog(startDialogs);
            sm.king = true;
        }
    }
}
