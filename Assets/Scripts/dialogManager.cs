using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class dialogManager : MonoBehaviour
{
    public string labelName = "DialogLabel";
    
    private UIDocument uiDocument;
    private Label dialogLabel;
    private List<string> dialogList;
    private int currentIndex;
    private bool isInitialized = false;

    void Start()
    {
        uiDocument = GetComponent<UIDocument>();
        if (uiDocument != null)
        {
            var root = uiDocument.rootVisualElement;
            dialogLabel = root.Q<Label>(labelName);
            root.pickingMode = PickingMode.Position;
            if (dialogLabel != null)
            {
                root.RegisterCallback<ClickEvent>(OnClick);
            }
            else
            {
            }
        }
        else
        {
        }
        if (!isInitialized)
        {
            if (uiDocument != null)
            {
                uiDocument.rootVisualElement.style.display = DisplayStyle.None;
            }
        }
    }

    void OnClick(ClickEvent evt)
    {
        ShowNextDialog();
    }

    public void ShowDialog(List<string> dialogs)
    {
        isInitialized = true;
        dialogList = dialogs;
        currentIndex = 0;
        if (uiDocument != null)
        {
            uiDocument.rootVisualElement.style.display = DisplayStyle.Flex;
        }
        if (dialogList != null && dialogList.Count > 0 && dialogLabel != null)
        {
            dialogLabel.text = dialogList[currentIndex];
        }
    }

    private void ShowNextDialog()
    {
        currentIndex++;
        
        if (currentIndex < dialogList.Count)
        {
            dialogLabel.text = dialogList[currentIndex];
        }
        else
        {
            if (uiDocument != null)
            {
                uiDocument.rootVisualElement.style.display = DisplayStyle.None;
            }
        }
    }
}
