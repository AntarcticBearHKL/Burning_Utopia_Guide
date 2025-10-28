using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMakeMagic : MonoBehaviour
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
                new DialogData("开心……不开心……开心……不开心……不开心……不开心", null, 0.65f, spec, 0.74f),
                new DialogData("happy你好，我是桑，专治你的不开心！", null, 0.65f, spec, 0.74f),
                new DialogData("不开心不是一种病，为什么要治；一直开心是一种病，为什么不治？", null, 0.65f, spec, 0.74f),
                new DialogData("智慧，我有点害怕了", speo, 0.65f, null, 0.74f),
                new DialogData("你是那个想要开心魔法的人类？", null, 0.65f, spec, 0.74f),
                new DialogData("命运！你想要快乐，而我却追逐哀伤", null, 0.65f, spec, 0.74f),
                new DialogData("想要不开心，不是一件很容易的事吗？比如被信任的人背叛，每天做无聊的工作，吃不饱饭", null, 0.65f, spec, 0.74f),
                new DialogData("有办法了，你饿上几顿，或者去撞树，求而不得，也是一种不开心", null, 0.65f, spec, 0.74f),
                new DialogData("精灵不用吃饭，吃糖只是为了开心；精灵也不会死，撞树只会痛", speo, 0.65f, null, 0.74f),
                new DialogData("至于求而不得，因为还有希望，所以也不伤心", null, 0.65f, spec, 0.74f),
                new DialogData("村长倒是经常伤心和生气，真想问问他是怎么做到的", null, 0.65f, spec, 0.74f),

                new DialogData("可惜他身体不好，一直在房里休息", null, 0.65f, spec, 0.74f),
                new DialogData("快乐会感染，愤怒也会感染，如果我能让村长生气，说不定……", null, 0.65f, spec, 0.74f),
                new DialogData("算了，和你这种幸福的人类说不明白，很抱歉我现在无法施展开心魔法", null, 0.65f, spec, 0.74f),
                new DialogData("有我要继续去寻找我的哀伤了……", null, 0.65f, spec, 0.74f),
                new DialogData("----树上好像结满了果实，不如摘一个吧----", null, 0.65f, spec, 0.74f),
            };
            dm.ShowDialog(startDialogs);
            sm.fruitClickble = true;
        }
    }
}
