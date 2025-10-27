using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DesLogin : MonoBehaviour
{
    private UIDocument uiDocument;
    private VisualElement buttonConfirm;

    // Start is called before the first frame update
    void Start()
    {
        uiDocument = GetComponent<UIDocument>();
        if (uiDocument != null)
        {
            buttonConfirm = uiDocument.rootVisualElement.Q<VisualElement>("buttonConfirm");
            if (buttonConfirm != null)
            {
                buttonConfirm.RegisterCallback<ClickEvent>(evt => uiDocument.rootVisualElement.style.display = DisplayStyle.None);
            }
        }
    }
}
