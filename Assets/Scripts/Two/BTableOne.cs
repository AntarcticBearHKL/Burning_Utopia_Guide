using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTableOne : MonoBehaviour
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
                new DialogData("除了梦之国皇宫，在哪里都喝不到这样香醇的葡萄酒", speo, 0.65f, null, 0.65f),
                new DialogData("可惜，美丽的公主和香醇的葡萄酒，都让一个不知道哪来的野种抢了去", speo, 0.65f, null, 0.65f),
                new DialogData("这野种比骑士长大人还厉害，找到了整个骑士团都没找到的精灵王国", null, 0.65f, spec, 0.65f),
                new DialogData("夫人别嘲笑我，您特意雇佣了几支雇佣兵分头出发，让你的孙子和王室联姻，不也没找到吗？", speo, 0.65f, null, 0.65f),
                new DialogData("不知道那个野种有什么运气，好在公主的妹妹玛格丽特也待字闺中", speo, 0.65f, null, 0.65f),
                new DialogData("她比她那相貌平平的姐姐漂亮多了", speo, 0.65f, null, 0.65f),
            };
            dm.ShowDialog(startDialogs);
            sm.table1 = true;
        }
    }
}
