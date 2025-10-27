using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DesLogin : MonoBehaviour
{
    public GameObject sm;
    
    private UIDocument uiDocument;
    private VisualElement buttonConfirm;

    void Start()
    {
        uiDocument = GetComponent<UIDocument>();
        if (uiDocument != null)
        {
            buttonConfirm = uiDocument.rootVisualElement.Q<VisualElement>("buttonConfirm");
            if (buttonConfirm != null)
            {
                buttonConfirm.RegisterCallback<ClickEvent>(evt =>
                {
                    if (sm != null)
                    {
                        DesManager manager = sm.GetComponent<DesManager>();
                        if (manager != null)
                        {
                            manager.Step3();
                        }
                    }
                });
            }
        }
    }
}
