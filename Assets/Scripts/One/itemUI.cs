using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class itemUI : MonoBehaviour
{
    public SceneOneManager sm;

    private VisualElement[] roots = new VisualElement[4];
    private VisualElement[] bs = new VisualElement[4];
    private VisualElement[] fs = new VisualElement[4];

    void Start()
    {
        var uiDocument = GetComponent<UIDocument>();
        if (uiDocument != null)
        {
            var root = uiDocument.rootVisualElement;
            for (int i = 0; i < 4; i++)
            {
                roots[i] = root.Q<VisualElement>($"Root{i + 1}");
                bs[i] = roots[i].Q<VisualElement>($"R{i + 1}B");
                fs[i] = roots[i].Q<VisualElement>($"R{i + 1}F");

                if (roots[i] != null)
                {
                    int index = i; 
                    roots[i].RegisterCallback<ClickEvent>(evt => {
                        ChooseB(index);
                    });
                }
            }
        }
    }

    public void GetF(int index)
    {
        if (index >= 0 && index < fs.Length && fs[index] != null)
        {
            fs[index].style.opacity = 1f;
        }

        if(index == 1)
        {
            sm.i1g = true;
        }
        else if(index == 2)
        {
            sm.i2g = true;
        }
        else if(index == 3)
        {
            sm.i3g = true;
        }
        else if(index == 4)
        {
            sm.i4g = true;
        }
    }

    public void ChooseB(int index)
    {
        if (index >= 0 && index < bs.Length && bs[index] != null)
        {
            if (sm != null && sm.itemChoose >= 0 && sm.itemChoose < 4)
            {
                int chosenIndex = sm.itemChoose;
                if (chosenIndex >= 0 && chosenIndex < bs.Length && bs[chosenIndex] != null)
                {
                    bs[chosenIndex].style.opacity = 0f; 
                }
            }

            bs[index].style.opacity = 0.5f;

            if (sm != null)
            {
                sm.itemChoose = index;
            }
        }
    }
}
