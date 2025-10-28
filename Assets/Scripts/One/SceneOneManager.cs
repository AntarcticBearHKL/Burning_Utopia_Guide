using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneOneManager : MonoBehaviour
{
    private GameObject currentPosition;
    public GameObject mainCamera;

    public GameObject dialogUI;
    public GameObject itemUI;

    public Sprite heroSprite;

    public bool i1g = false;
    public bool i2g = false;
    public bool i3g = false;
    public bool i4g = false;

    public int itemChoose = -1;

    public bool princessHitted = false;

    public bool finalGateOpen = false;

    void Start()
    {
        if (dialogUI != null)
        {
            dialogUI dm = dialogUI.GetComponent<dialogUI>();
            if (dm != null)
            {
                List<DialogData> startDialogs = new List<DialogData> { 
                    new DialogData("我们的勇者桑已经出发了！她要去救出公主，可怜的公主，被她的父亲当成交易的货物", null, 0, null, 0),
                    new DialogData("国王听说精灵的魔法能让人长生不老，所以下令，谁能将精灵的魔法献给国王，谁就可以迎娶公主。也是，长生不老后，有无穷的后代，谁还会在乎一个并不非常貌美的公主呢？", null, 0, null, 0),
                    new DialogData("我在乎！", heroSprite, 0.65f, null, 0),
                    new DialogData("公主是最美好的存在！她被困在那个冷酷的宫殿里，等待我拯救", heroSprite, 0, null, 0),
                    new DialogData("我已经找到与世隔绝的精灵王国了，一定能将精灵的魔法带给国王！", heroSprite, 0, null, 0),
                    new DialogData("为了公主，一切付出都值得……", heroSprite, 0, null, 0),
                    new DialogData("----原来我小时候这么恋爱脑吗？----", null, 0, null, 0),

                };
                dm.ShowDialog(startDialogs);
            }
        }
    }

    void Update()
    {
        
    }

    public void UpdatePosition(GameObject newPosition)
    {
        if (currentPosition == newPosition)
        {
            return;
        }

        if (currentPosition != null)
        {
            movePoint previousPoint = currentPosition.GetComponent<movePoint>();
            if (previousPoint != null)
            {
                previousPoint.Leave();
            }
        }
        currentPosition = newPosition;
    }

    public bool IsDialogActive()
    {
        if (dialogUI != null)
        {
            dialogUI dm = dialogUI.GetComponent<dialogUI>();
            if (dm != null)
            {
                return dm.IsDialogActive();
            }
        }
        return false;
    }

    public void GetItem(int itemIndex)
    {
        switch (itemIndex)
        {
            case 1:
                i1g = true;
                break;
            case 2:
                i2g = true;
                break;
            case 3:
                i3g = true;
                break;
            case 4:
                i4g = true;
                break;
            default:
                Debug.LogWarning("Invalid item index");
                return;
        }

        if (itemUI != null)
        {
            itemUI ui = itemUI.GetComponent<itemUI>();
            if (ui != null)
            {
                ui.GetF(itemIndex - 1);
            }
        }
    }
}
