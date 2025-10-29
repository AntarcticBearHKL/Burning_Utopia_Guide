using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BStirProf : MonoBehaviour
{
    public bool isFunc = true;

    public Sprite speo;
    public Sprite spec;

    public void trigger(SceneOneManager sm)
    {
        dialogUI dm = sm.dialogUI.GetComponent<dialogUI>();

        List<DialogData> startDialogs;
        if (dm != null)
        {
            if (sm.i1g & sm.i3g)
            {
                startDialogs = new List<DialogData> {
                    new DialogData("", null, 0, null, 0),
                    new DialogData("这是，可以用来做硬糖的特别鲜花！", null, 0.65f, spec, 0.74f),
                    new DialogData("coy一直记着这件事，他拜托我去找来送给你", speo, 0.65f, null, 0.74f),
                    new DialogData("能告诉我，你为什么生它气吗？", speo, 0.65f, null, 0.74f),
                    new DialogData("我没有讨厌coy，我只是讨厌我自己", null, 0.65f, spec, 0.74f),
                    new DialogData("我喜欢搅拌糖浆，喜欢看到它们变成糖果的样子", null, 0.65f, spec, 0.74f),
                    new DialogData("可其它精灵总说，你应该去唱歌，你应该去跳舞，搅拌糖浆对女孩子来说太辛苦了", null, 0.65f, spec, 0.74f),
                    new DialogData("为什么没人问我喜欢做什么呢？", null, 0.65f, spec, 0.74f),
                    new DialogData("我知道其它精灵也是好意，但正因为这是好意，我才无法拒绝", null, 0.65f, spec, 0.74f),
                    new DialogData("我只希望coy能懂我，能在意我是否开心", null, 0.65f, spec, 0.74f),
                    new DialogData("啊不好意思勇者大人，我又一不小心说太多了", null, 0.65f, spec, 0.74f),
                    new DialogData("勇者大人喜欢做什么呢？勇者大人一定很喜欢公主吧，才排除万难来救她", null, 0.65f, spec, 0.74f),
                    new DialogData("是的，公主是最美好的存在", speo, 0.65f, null, 0.74f),
                    new DialogData("真是令人羡慕的情感！公主喜欢做什么呢？", null, 0.65f, spec, 0.74f),
                    new DialogData("精灵王国里也有一位精灵公主，但她只喜欢背着族长偷情……", null, 0.65f, spec, 0.74f),

                    new DialogData("公主喜欢什么呢？勇者绞尽脑汁，也想不出来，他甚至发现，公主的面容也已经模糊了", null, 0.65f, null, 0.74f),
                    new DialogData("10几岁的勇者，被强制给国王劳役，搬运货物、修整城堡，每日的消遣是收工后和工友们一起去酒馆闲聊玩乐，点的当然是最便宜的淡啤酒。", null, 0.65f, null, 0.74f),
                    new DialogData("一天，喝完淡啤酒的桑，拨弄着零星的铜币，准备付酒钱。善良的公主看见这一幕，帮她付了酒钱，请她喝了一杯蜂蜜酒。", null, 0.65f, null, 0.74f),
                    new DialogData("桑才知道，原来酒的泡沫可以这么绵密，原来酒也有甜味而不是辣味。", null, 0.65f, null, 0.74f),
                    new DialogData("桑想报答公主，公主对她说，想要报答，就得到精灵的魔法，来救她。", null, 0.65f, null, 0.74f),
                    new DialogData("至于公主为什么会出现在酒馆，在城堡里为什么不开心？勇者并不知道", null, 0.65f, null, 0.74f),
                    new DialogData("这是一种感情，还是一种执念？勇者也不知道。勇者只知道，公主需要拯救，她想公主开心", null, 0.65f, null, 0.74f),
                    new DialogData("----(对这个公主的感情，有一种很熟悉的感觉，当时应该参考了现实中的人物，是谁呢？)----", null, 0.65f, null, 0.74f),

                };
                dm.ShowDialog(startDialogs);
                sm.GetItem(4);
            }
            else
            {
                startDialogs = new List<DialogData> {
                    new DialogData("", null, 0, null, 0),
                    new DialogData("讨厌coy，其他精灵这么说也就算了，为什么你也不明白……", null, 0.65f, spec, 0.74f),
                    new DialogData("听起来coy对你来说很重要", speo, 0.65f, null, 0.74f),
                    new DialogData("啊，勇者大人！我听其他小精灵提到过你，你本人比传说更高大，还有一双深情的眼睛", null, 0.65f, spec, 0.74f),
                    new DialogData("不知道你是否遇见过coy，它在生产线末端负责包装糖果", null, 0.65f, spec, 0.74f),
                    new DialogData("我一直想要一种特别的花，有了它，我就可以让软糖变成硬糖", null, 0.65f, spec, 0.74f),
                    new DialogData("coy总说帮我找，可后来我们吵架了……不知道coy现在怎么样了", null, 0.65f, spec, 0.74f),
                    new DialogData("----(看来需要特别的花和软糖)----", null, 0.65f, null, 0.74f),
                };
                dm.ShowDialog(startDialogs);
            }
        }
    }
}
