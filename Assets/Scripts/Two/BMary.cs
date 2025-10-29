using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMary : MonoBehaviour
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
                new DialogData("您是不是第一次参加舞会，骑士先生？", null, 0.65f, spec, 0.74f),
                new DialogData("是，但您是怎么看出来的？", null, 0.65f, spec, 0.74f),
                new DialogData("您一句话都没说，就这么径直地走过来了呀！", null, 0.65f, spec, 0.74f),
                new DialogData("要请女士跳舞的话，得有一套流程才行", speo, 0.65f, null, 0.74f),
                new DialogData("啊……我没有……非常抱歉，我是来找公主殿下的", null, 0.65f, spec, 0.74f),
                new DialogData("可是玛格丽特公主已经和杰克骑士长私会半年了……", null, 0.65f, spec, 0.74f),
                new DialogData("我不是找玛格丽特公主，是……", speo, 0.65f, null, 0.74f),
                new DialogData("特蕾西公主？她喜欢大胡子，除非你现在就能长出来", null, 0.65f, spec, 0.74f),
                new DialogData("都不是，自我介绍下，我是勇者桑，我在找银白头发的公主殿下", null, 0.65f, spec, 0.74f),
                new DialogData("原来，你就是那位大名鼎鼎的勇者", null, 0.65f, spec, 0.74f),
                new DialogData("你找公主，却连她叫什么名字都不知道？", null, 0.65f, spec, 0.74f),
                new DialogData("我确实不知道她的名字，但我对她的感情！有些事，像您这样的小姐是没法理解的……", null, 0.65f, spec, 0.74f),
                new DialogData("是吗，那公主喜欢什么？", null, 0.65f, spec, 0.74f),
                new DialogData("我有个一起长大的朋友，她十岁起就拉着我练习宫廷舞蹈，每年至少添置四套礼服和一堆首饰	", speo, 0.65f, null, 0.74f),
                new DialogData("后来，她厌倦了舞会，开始学习骑马射箭，她的父亲给了她一匹优雅的白马", null, 0.65f, spec, 0.74f),
                new DialogData("她渴望冒险，希望能够邂逅一位英俊潇洒的骑士，一起逃出无聊生活的桎梏，于是她来到这个迎接传奇勇者的舞会……	", null, 0.65f, spec, 0.74f),
                new DialogData("很抱歉，我……", speo, 0.65f, null, 0.74f),
                new DialogData("不用抱歉，大人，我猜您一定以为，我说的就是我自己", null, 0.65f, spec, 0.74f),
                new DialogData("她逃了，躲在花园里，害怕这又是命运的另一个骗局", null, 0.65f, spec, 0.74f),
                new DialogData("我穿上她的裙子，戴上她的首饰，自己叫了马车，来到舞会……", null, 0.65f, spec, 0.74f),

                new DialogData("很蠢是吧……赌上一切，就是为了走进一个别人抛弃的梦", null, 0.65f, spec, 0.74f),
                new DialogData("我终于看见了异国的鲜花，歌唱的乐队，还有潇洒的骑士……我知道这些不属于我", null, 0.65f, spec, 0.74f),
                new DialogData("可人有时不就是为了一个执念活着吗？", null, 0.65f, spec, 0.74f),
                new DialogData("我站在这里，有谁能看出我是个女仆？一样有人走过来向我献媚", speo, 0.65f, null, 0.74f),
                new DialogData("有时我真不明白，我和那些公主到底有什么区别？所以，大人，别说我不理解", null, 0.65f, spec, 0.74f),
                new DialogData("对不起，我要先走一步了……	", null, 0.65f, spec, 0.74f),
                new DialogData("公主在后花园，您快去找她吧，无论如何，感谢您的倾听，祝您，今晚顺利……", speo, 0.65f, null, 0.74f),
                new DialogData("……", null, 0.65f, spec, 0.74f),
            };
            dm.ShowDialog(startDialogs);
            sm.mary = true;
        }
    }
}
