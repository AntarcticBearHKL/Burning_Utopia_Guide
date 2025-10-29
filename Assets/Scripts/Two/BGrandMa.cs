using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGrandMa : MonoBehaviour
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
                new DialogData("夫人您好，我是桑，请问你有看到公主吗？", speo, 0.65f, null, 0.64f),
                new DialogData("抱歉，关于公主，虽然我是她的教母，但你还是得去问国王和皇后殿下", null, 0.65f, spec, 0.64f),
                new DialogData("谢谢您，不瞒您说，我问了很多人，您是第一个告诉我可以怎么办的人", speo, 0.65f, null, 0.64f),
                new DialogData("稍等一下年轻人，你是勇者桑？你和传闻中……很不一样", null, 0.65f, spec, 0.64f),
                new DialogData("有关于我的传闻吗，是好的还是不好的？公主也知道吗？", speo, 0.65f, null, 0.64f),
                new DialogData("传闻你是渴求财富的穷小子，计划用假的魔法糖果哄骗国王迎娶公主，篡夺王位", null, 0.65f, spec, 0.64f),

                new DialogData("这……如果你看见公主，请您告诉她这些都不是真的", speo, 0.65f, null, 0.64f),
                new DialogData("不知道公主还记不记得我，但是，我只是不想她不开心……", speo, 0.65f, null, 0.64f),
                new DialogData("……我都有点被你感动了，不过就算传闻是真的，有欲望也没什么不好", null, 0.65f, spec, 0.64f),
                new DialogData("这里到处都是有欲望的人……享受舞会吧，桑", null, 0.65f, spec, 0.64f),
            };
            dm.ShowDialog(startDialogs);
            sm.grandma = true;
        }
    }
}
