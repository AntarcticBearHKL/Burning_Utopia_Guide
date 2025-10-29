using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STManager : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject DialogUI;

    public bool table1 = false;
    public bool knight = false;
    public bool grandma = false;
    public bool kingtable = false;
    public bool king = false;
    public bool mary = false;
    public bool people = false;

    void Start()
    {
        if (DialogUI != null)
        {
            dialogUI dm = DialogUI.GetComponent<dialogUI>();
            if (dm != null)
            {
                List<DialogData> startDialogs = new List<DialogData> { 
                    new DialogData("我们的勇者桑终于来到了梦之国的宫廷宴会厅！", null, 0, null, 0),
                    new DialogData("这里的每一寸地板，每一根廊柱，都曾有她的参与", null, 0, null, 0),
                    new DialogData("但只有这次，桑是以被邀请而不是被奴役的身份前来", null, 0.65f, null, 0),
                    new DialogData("她的英雄事迹传遍了梦之国，人人都歌颂着勇者桑的名字", null, 0, null, 0),
                    new DialogData("歌颂伟大的王国，伟大的国王，长生不老的传奇，永垂不朽的统治", null, 0, null, 0),
                    new DialogData("只有我们的勇者桑，想念着公主……", null, 0, null, 0),
                };
                dm.ShowDialog(startDialogs);
            }
        }
    }

    void Update()
    {
        
    }

    public void step1()
    {
        if (MainCamera != null)
        {
            Vector3 pos = MainCamera.transform.position;
            pos.x = 0f;
            pos.y = 0f;
            pos.z = -1f;
            MainCamera.transform.position = pos;
        }
    }

    public void step3()
    {
        Debug.Log("Camera moved to position: ");
        if (MainCamera != null)
        {
            Vector3 pos = MainCamera.transform.position;
            pos.x = 20f;
            pos.y = -6.8f;
            pos.z = -1f;
            MainCamera.transform.position = pos;
        }
    }

    public void step2()
    {
        if (MainCamera != null)
        {
            Vector3 pos = MainCamera.transform.position;
            pos.x = 20f;
            pos.y = 5.3f;
            pos.z = -1f;
            MainCamera.transform.position = pos;
        }
    }

    public void step4()
    {
        if (MainCamera != null)
        {
            Vector3 pos = MainCamera.transform.position;
            pos.x = 41.2f;
            pos.y = 0f;
            pos.z = -1f;
            MainCamera.transform.position = pos;
        }
    }


    public bool IsDialogActive()
    {
        if (DialogUI != null)
        {
            dialogUI dm = DialogUI.GetComponent<dialogUI>();
            if (dm != null)
            {
                return dm.IsDialogActive();
            }
        }
        return false;
    }
}
