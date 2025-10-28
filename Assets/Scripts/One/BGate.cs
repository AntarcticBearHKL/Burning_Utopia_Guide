using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGate : MonoBehaviour
{
    public bool isFunc = true;

    public void trigger(SceneOneManager sm)
    {
        dialogUI dm = sm.dialogUI.GetComponent<dialogUI>();
        if (dm != null)
        {
            List<DialogData> startDialogs;
            if(sm.readyToLeave)
            {
                SceneManager.LoadScene("SceneTwo");
            }
            else if (sm.i4g)
            {
                startDialogs = new List<DialogData> {
                    new DialogData("", null, 0, null, 0),
                    new DialogData("---(我记得得到魔法糖果，从传送门离开应该就算通关了)---", null, 0.65f, null, 0.74f),
                    new DialogData("---(当初是为什么做这个关卡呢？)---", null, 0.65f, null, 0.74f),
                    new DialogData("---(小时候，除了程意，我好像很少有说话的朋友)---", null, 0.65f, null, 0.74f),
                    new DialogData("---(可我也不敢和程意说太多话，怕被嫌烦)---", null, 0.65f, null, 0.74f),
                    new DialogData("---(所以做了一堆快乐的小精灵，它们永远会等我，永远不会嫌我烦)---", null, 0.65f, null, 0.74f),
                    new DialogData("---(转念一想现在也是这样)---", null, 0.65f, null, 0.74f),
                    new DialogData("---(但比小时候多了点钱可以用来安慰自己)---", null, 0.65f, null, 0.74f),
                    new DialogData("---(总之, 先到下一关, 继续记录bug吧)---", null, 0.65f, null, 0.74f),
                };
                dm.ShowDialog(startDialogs);
                sm.readyToLeave = true;
            }
            else
            {
                startDialogs = new List<DialogData> {
                    new DialogData("", null, 0, null, 0),
                    new DialogData("这么快就放弃吗", null, 0.65f, null, 0.74f),
                    new DialogData("你忍心公主被一个大腹便便的富商，还是那些自鸣得意的“骑士”带走？", null, 0.65f, null, 0.74f),
                    new DialogData("----(不能出去，要得到精灵的魔法)----", null, 0.65f, null, 0.74f),
                };
                dm.ShowDialog(startDialogs);
            }
        }
    }
}
