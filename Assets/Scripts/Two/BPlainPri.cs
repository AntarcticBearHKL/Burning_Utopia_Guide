using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPlainPri : MonoBehaviour
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
                new DialogData("你来了，桑，我一直在等你", null, 0.65f, spec, 0.74f),
                new DialogData("公主殿下！你……你最近开心吗？", null, 0.65f, spec, 0.74f),
                new DialogData("开心…很少有人这么问我……我们这么久没见，你第一句问我是否开心？", null, 0.65f, spec, 0.74f),
                new DialogData("不过，很开心能见到你，你喜欢这儿吗？", speo, 0.65f, null, 0.74f),
                new DialogData("我刚刚去了宴会厅，去了舞会，见到了国王和王后，还有那些贵族", null, 0.65f, spec, 0.74f),
                new DialogData("你喜欢他们吗？", null, 0.65f, spec, 0.74f),

                new DialogData("不喜欢，他们都一个样，我分不清谁是谁", null, 0, null, 0),
                new DialogData("还老是说…", null, 0.65f, spec, 0.74f),
                new DialogData("说有关我的流言，我的坏话，是吗？", null, 0.65f, spec, 0.74f),
                new DialogData("没事的，他们不一定真这么想，只是他们需要谈资", null, 0.65f, spec, 0.74f),
                new DialogData("就像他们相同的衣服，相同的饰品一样", speo, 0.65f, null, 0.74f),
                new DialogData("还有他们相同的目的——炫耀他们的财富，维系他们的地位", null, 0.65f, spec, 0.74f),
                new DialogData("你呢，桑？你为什么来到皇宫，为什么去冒险拿到精灵的魔法？", null, 0.65f, spec, 0.74f),

                new DialogData("因为我答应过你，我想拯救你", null, 0, null, 0),
                new DialogData("拯救我？", null, 0.65f, spec, 0.74f),
                new DialogData("当然！之前……我一直在修筑宫殿", null, 0.65f, spec, 0.74f),
                new DialogData("你可能从没注意到我，但是我经常负责修缮城堡的外墙！", null, 0.65f, spec, 0.74f),
                new DialogData("每次你经过宫殿的外廊，我都能远远的看见你，看见你银白色的头发，和忧愁的表情……", speo, 0.65f, null, 0.74f),
                new DialogData("那天，你帮我在酒馆付钱，我一眼就认出那是你，一样的白发，一样的忧愁", null, 0.65f, spec, 0.74f),
                new DialogData("我不知道该做什么，我只知道，我不想让你不开心", null, 0.65f, spec, 0.74f),

                new DialogData("你在皇宫里不开心，我就带你离开皇宫", null, 0, null, 0),
                new DialogData("原来……桑……谢谢你，可惜已经太晚了", null, 0.65f, spec, 0.74f),
                new DialogData("太晚了是什么意思？", null, 0.65f, spec, 0.74f),


                new DialogData("忘掉刚刚的对话吧，是我失言了", null, 0, null, 0),
                new DialogData("让我们还是用公主和解救公主的勇者的身份对话吧", null, 0.65f, spec, 0.74f),
                new DialogData("勇者大人", null, 0.65f, spec, 0.74f),
            };
            dm.ShowDialog(startDialogs);
        }
    }
}
