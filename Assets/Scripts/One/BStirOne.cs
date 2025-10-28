using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BStirOne : MonoBehaviour
{
    public bool isFunc = true;

    public Sprite speo;
    public Sprite spec;

    public void trigger(SceneOneManager sm)
    {
        dialogUI dm = sm.dialogUI.GetComponent<dialogUI>();
        if (dm != null)
        {
            List<DialogData> startDialogs;
            startDialogs = new List<DialogData> {
                new DialogData("", null, 0, null, 0),
                new DialogData("你是，人类？！太好了，我第一次遇见活着的人类！", null, 0.65f, spec, 0.74f),
                new DialogData("你好高呀，你的衣服为什么亮晶晶的？是用什么材料做的呢？", null, 0.65f, spec, 0.74f),
                new DialogData("哎呀差点忘了！你想要糖果吗？来到精灵王国怎么可以不尝尝我们的糖果！", null, 0.65f, spec, 0.74f),
                new DialogData("我想要带精灵魔法的糖果", speo, 0.65f, null, 0.74f),
                new DialogData("creaty也想研究出带精灵魔法的糖果", null, 0.65f, spec, 0.74f),
                new DialogData("但是只有happy能给糖果赋予开心魔法", null, 0.65f, spec, 0.74f),
                new DialogData("开心魔法也只有开心的小精灵才能施展", null, 0.65f, spec, 0.74f),
                new DialogData("happy最近总是不快乐，没有办法施展开心魔法", null, 0.65f, spec, 0.74f),

                new DialogData("它为什么不开心？", speo, 0.65f, null, 0.74f),
                new DialogData("我也不知道，它总说想要知道伤心是什么感觉，但我没办法发明出来", null, 0.65f, spec, 0.74f),
                new DialogData("不过，你们人类应该有办法，书上总是说人类会互相吵架攻击，会这样做的人，应该都很伤心吧", null, 0.65f, spec, 0.74f),
            };
            dm.ShowDialog(startDialogs);
        }
    }
}
