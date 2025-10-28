using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[System.Serializable]
public class DialogData
{
    public string dialogText;
    public Sprite speaker1Sprite;
    public float speaker1BottomPosition; 
    public Sprite speaker2Sprite;
    public float speaker2BottomPosition;

    public DialogData(string text, Sprite sprite1, float bottomPos1, Sprite sprite2, float bottomPos2)
    {
        dialogText = text;
        speaker1Sprite = sprite1;
        speaker1BottomPosition = Mathf.Clamp01(bottomPos1);
        speaker2Sprite = sprite2;
        speaker2BottomPosition = Mathf.Clamp01(bottomPos2);
    }
}

public class dialogUI : MonoBehaviour
{
    public string labelName = "DialogLabel";
    public string speaker1VisualName = "Speaker1Visual";
    public string speaker2VisualName = "Speaker2Visual";
    
    private UIDocument uiDocument;
    private Label dialogLabel;
    private VisualElement speaker1Visual;
    private VisualElement speaker2Visual;
    private List<DialogData> dialogList;
    private int currentIndex;
    private bool isInitialized = false;

    void Start()
    {
        uiDocument = GetComponent<UIDocument>();
        if (uiDocument != null)
        {
            var root = uiDocument.rootVisualElement;
            dialogLabel = root.Q<Label>(labelName);
            speaker1Visual = root.Q<VisualElement>(speaker1VisualName);
            speaker2Visual = root.Q<VisualElement>(speaker2VisualName);
            root.pickingMode = PickingMode.Position;
            if (dialogLabel != null)
            {
                root.RegisterCallback<ClickEvent>(OnClick);
            }
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

    public void ShowDialog(List<DialogData> dialogs)
    {
        isInitialized = true;
        dialogList = dialogs;
        currentIndex = 0;
        if (uiDocument != null)
        {
            uiDocument.rootVisualElement.style.display = DisplayStyle.Flex;
        }
        if (dialogList != null && dialogList.Count > 0)
        {
            ShowDialogAtIndex(currentIndex);
        }
    }

    private void ShowDialogAtIndex(int index)
    {
        if (dialogList == null || index >= dialogList.Count)
            return;

        DialogData currentDialog = dialogList[index];

        // 设置对话文本
        if (dialogLabel != null)
        {
            dialogLabel.text = currentDialog.dialogText;
        }

        // 设置说话者1的背景图和位置
        if (speaker1Visual != null)
        {
            if (currentDialog.speaker1Sprite != null)
            {
                speaker1Visual.style.backgroundImage = new StyleBackground(currentDialog.speaker1Sprite);
                // 设置位置：使用top，从顶部开始计算百分比
                // 0表示顶部，1表示底部，所以需要反转：(1 - value) * 100
                speaker1Visual.style.top = Length.Percent((1 - currentDialog.speaker1BottomPosition) * 100);
                speaker1Visual.style.position = Position.Absolute;
            }
            else
            {
                speaker1Visual.style.backgroundImage = StyleKeyword.None;
            }
        }

        // 设置说话者2的背景图和位置
        if (speaker2Visual != null)
        {
            if (currentDialog.speaker2Sprite != null)
            {
                speaker2Visual.style.backgroundImage = new StyleBackground(currentDialog.speaker2Sprite);

                speaker2Visual.style.top = Length.Percent((1 - currentDialog.speaker2BottomPosition) * 100);
                speaker2Visual.style.position = Position.Absolute;
            }
            else
            {
                speaker2Visual.style.backgroundImage = StyleKeyword.None;
            }
        }
    }

    private void ShowNextDialog()
    {
        currentIndex++;
        
        if (currentIndex < dialogList.Count)
        {
            ShowDialogAtIndex(currentIndex);
        }
        else
        {
            if (uiDocument != null)
            {
                uiDocument.rootVisualElement.style.display = DisplayStyle.None;
            }
        }
    }

    public bool IsDialogActive()
    {
        return uiDocument != null && uiDocument.rootVisualElement.style.display == DisplayStyle.Flex;
    }
}
