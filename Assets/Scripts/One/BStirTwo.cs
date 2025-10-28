using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BStirTwo : MonoBehaviour
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

                new DialogData("勇……勇者……你……好……", null, 0.65f, spec, 0.74f),
                new DialogData("你……好……有……什么……事？", speo, 0.65f, null, 0.74f),

                new DialogData("勇者大人，可以帮我一个忙吗？", null, 0.65f, spec, 0.74f),
                new DialogData("你可以帮我，帮我找到cuty吗，她在搅拌糖浆那边工作！", null, 0.65f, spec, 0.74f),
                new DialogData("搅拌糖浆又苦又累，最开始，大家都觉得以cuty的体力和力气，做这个工作太辛苦了", null, 0.65f, spec, 0.74f),
                new DialogData("我也觉得！cuty那么可爱，她应该开心地在树上唱歌，和其他的小精灵一起玩耍", null, 0.65f, spec, 0.74f),
                new DialogData("cuty是我最好的朋友，有一天，cuty下班后又直接躺倒在了草地上", null, 0.65f, spec, 0.74f),
                new DialogData("我忍不住劝她，就算不工作，我也会每天给cuty送糖果的", null, 0.65f, spec, 0.74f),
                new DialogData("可是，她好像因此生气了……", null, 0.65f, spec, 0.74f),
                new DialogData("听起来是一个误会", speo, 0.65f, null, 0.74f),

                new DialogData("我想了解cuty，但她总是什么也不和我们说，只说工作很开心", null, 0.65f, spec, 0.74f),
                new DialogData("坏cuty！但我还是想要她开心", null, 0.65f, spec, 0.74f),
                new DialogData("勇者大人，拜托你帮我给cuty“特别的鲜花”吧！", null, 0.65f, spec, 0.74f),
                new DialogData("听说不同的植物放到糖浆里，会做出不同样式的糖果", null, 0.65f, spec, 0.74f),
                new DialogData("cuty那么喜欢她的工作的话，做出新的糖果，她一定会很开心的！", null, 0.65f, spec, 0.74f),
                new DialogData("没问题，但，你为什么不亲自给呢？", speo, 0.65f, null, 0.74f),
                new DialogData("因为……拜托大人别问了！大人把东西带到并且治好happy的病后，我会给大人魔法糖果的！", null, 0.65f, spec, 0.74f),

            };
            dm.ShowDialog(startDialogs);
        }
    }
}
