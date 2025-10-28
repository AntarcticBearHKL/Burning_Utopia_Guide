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
                new DialogData("！你怎么知道！", speo, 0.65f, spec, 0.74f),
                new DialogData("播种的过程有时很枯燥，所以总会思考更多", null, 0.65f, spec, 0.74f),
                new DialogData("你想寻找的糖果，精灵制作的糖果，都来自神树的果实", null, 0.65f, spec, 0.74f),
                new DialogData("神树孕育一切，为精灵提供居所、提供食物", null, 0.65f, spec, 0.74f),
                new DialogData("想要得到带精灵魔法的糖果，就要到一切的源头……", null, 0.65f, spec, 0.74f),
                new DialogData("一切的源头，是指神树？", speo, 0.65f, null, 0.74f),
                new DialogData("神树，和生产糖果的流水线", null, 0.65f, spec, 0.74f),
            };
            dm.ShowDialog(startDialogs);
        }
    }
}
