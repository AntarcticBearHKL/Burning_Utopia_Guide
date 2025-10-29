using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPeople : MonoBehaviour
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
                new DialogData("你们看见国王陛下今天的脸色了吗？", null, 0.65f, spec, 0.64f),
                new DialogData("把心爱的女儿嫁给一个没有任何贵族血统的贫民，任何父亲都不会有好脸色吧	", null, 0.65f, spec, 0.64f),
                new DialogData("要我说，陛下对公主够好了", null, 0.65f, spec, 0.64f),
                new DialogData("她既不如玛格丽特公主美丽，又不如特蕾西公主智慧，还去酒吧和那些下层人混在一起", speo, 0.65f, null, 0.64f),
                new DialogData("我听说啊，公主有一次赌博后宿醉在街上，第二天被城里的收尸人拖回来的", null, 0.65f, spec, 0.64f),
                new DialogData("什么！这也太不体面了吧", null, 0.65f, spec, 0.64f),
                new DialogData("所以啊，国王才着急把公主嫁出去，公主说不定就喜欢这些贫民呢", null, 0.65f, spec, 0.64f),
            };
            dm.ShowDialog(startDialogs);
            sm.people = true;
        }
    }
}
