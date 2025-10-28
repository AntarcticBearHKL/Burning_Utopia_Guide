using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPlaySprite : MonoBehaviour
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
                new DialogData("你又来了！我是不会跟你离开精灵王国的！", null, 0.65f, spec, 0.74f),
                new DialogData("狡猾的人类，比我们整个家族加起来还大的巨魔……", null, 0.65f, spec, 0.74f),
                new DialogData("虽然你看起来是个呆呆的好人，我很想帮助你，但是，从来没有精灵走出王国过", null, 0.65f, spec, 0.74f),
                new DialogData("那，善良的小精灵，有没有别的办法将你们的魔法带走呢？", speo, 0.65f, null, 0.74f),
                new DialogData("有办法！在过去，每颗精灵糖果都会带有精灵独特的魔法", null, 0.65f, spec, 0.74f),
                new DialogData("精灵的魔法很容易消散，只能附在糖果上", null, 0.65f, spec, 0.74f),
                new DialogData("可惜不知道为什么，我们很久都没吃到带快乐魔法的糖果了", null, 0.65f, spec, 0.74f),
                new DialogData("你可以去问问播种的精灵，它们懂得比我多多了", null, 0.65f, spec, 0.74f),
                new DialogData("谢谢你kindy！你是我见过最善良的小精灵~", speo, 0.65f, null, 0.74f),
            };
            dm.ShowDialog(startDialogs);
        }
    }
}
