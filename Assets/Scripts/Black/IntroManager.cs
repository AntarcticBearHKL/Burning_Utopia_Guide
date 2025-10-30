using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    public GameObject uiObject;

    void Start()
    {
        if (uiObject != null)
        {
            List<string> introTexts = new List<string>
            {
                "点击来与道具和角色互动",
                "解出谜题或获得特定道具，点击传送门通往下一关"
            };
            uiObject.GetComponent<BlackUI>().ShowContent(introTexts, "Desktop");
        }
    }

    void Update()
    {
        
    }
}
