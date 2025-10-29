using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPlantSprite : MonoBehaviour
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
                new DialogData("桑你好，你是想问怎么得到带精灵魔法的糖果吗？", null, 0.65f, spec, 0.74f),
                new DialogData("！你怎么知道！", speo, 0.65f, null, 0.74f),
                new DialogData("播种的过程有时很枯燥，所以总会思考更多", null, 0.65f, spec, 0.74f),
                new DialogData("你想寻找的糖果，精灵制作的糖果，都来自神树的果实", null, 0.65f, spec, 0.74f),
                new DialogData("神树孕育一切，为精灵提供居所、提供食物", null, 0.65f, spec, 0.74f),
                new DialogData("想要得到带精灵魔法的糖果，就要到一切的源头……", null, 0.65f, spec, 0.74f),
                new DialogData("一切的源头，是指神树？", speo, 0.65f, null, 0.74f),
                new DialogData("神树，和生产糖果的流水线", null, 0.65f, spec, 0.74f),

                new DialogData("这还是我第一次，看见完整的精灵王国", speo, 0.65f, null, 0.74f),
                new DialogData("似乎所有的精灵，都很快乐", speo, 0.65f, null, 0.74f),
                new DialogData("当然，快乐，也是我们的工作！", null, 0.65f, spec, 0.74f),
                new DialogData("但是，就像总有人不想工作一样，也有精灵不想快乐", null, 0.65f, spec, 0.74f),
                new DialogData("如果我每天像你一样种地的话，我也快乐不起来", speo, 0.65f, null, 0.74f),
                new DialogData("我做得是非常神圣的工作！精灵将部分神树的果实用于播种", null, 0.65f, spec, 0.74f),
                new DialogData("这些种子能长成各种各样神奇的植物，做不同口味的糖果！", null, 0.65f, spec, 0.74f),
                new DialogData("我们最近培养出了一种“特别的鲜花”，它可以……", null, 0.65f, spec, 0.74f),
                new DialogData("可以？", speo, 0.65f, null, 0.74f),
                new DialogData("咳咳，还没研究出来它可以干什么，但可以先给你欣赏一下", null, 0.65f, spec, 0.74f),
                new DialogData("嗯，可以先向我显摆一下", speo, 0.65f, null, 0.74f),

                new DialogData("----(不如带上一朵特别的鲜花吧)----", null, 0.65f, null, 0.74f),
            };
            dm.ShowDialog(startDialogs);

            sm.flowerClickable = true;
        }
    }
}
