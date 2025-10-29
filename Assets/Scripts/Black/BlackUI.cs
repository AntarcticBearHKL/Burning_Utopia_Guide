using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class BlackUI : MonoBehaviour
{
    public string contentLabelName = "Content";

    private UIDocument uiDocument;
    private VisualElement root;
    private Label contentLabel;
    private List<string> contentList;
    private int currentIndex;
    private string targetSceneName;

    void Awake()
    {
        InitializeUI();
    }

    void Start()
    {
        if (uiDocument == null)
        {
            InitializeUI();
        }
    }

    private void InitializeUI()
    {
        if (uiDocument != null) return;

        uiDocument = GetComponent<UIDocument>();
        if (uiDocument != null)
        {
            root = uiDocument.rootVisualElement;
            contentLabel = root.Q<Label>(contentLabelName);

            root.pickingMode = PickingMode.Position;
            root.RegisterCallback<ClickEvent>(OnClick);

            root.style.display = DisplayStyle.None;
        }
    }

    void OnClick(ClickEvent evt)
    {
        ShowNextContent();
    }

    public void ShowContent(List<string> contents, string sceneName)
    {
        if (uiDocument == null || root == null || contentLabel == null)
        {
            InitializeUI();
        }

        if (contents == null || contents.Count == 0)
        {
            return;
        }

        contentList = contents;
        targetSceneName = sceneName;
        currentIndex = 0;

        if (root != null)
        {
            root.style.display = DisplayStyle.Flex;
        }

        UpdateContentDisplay();
    }

    private void UpdateContentDisplay()
    {
        if (contentList == null || currentIndex >= contentList.Count)
        {
            return;
        }

        if (contentLabel != null)
        {
            contentLabel.text = contentList[currentIndex];
        }
    }

    private void ShowNextContent()
    {
        currentIndex++;

        if (currentIndex < contentList.Count)
        {
            UpdateContentDisplay();
        }
        else
        {
            if (!string.IsNullOrEmpty(targetSceneName))
            {
                if (targetSceneName == "ENDGAME")
                {
                    Application.Quit();
                }
                else
                {
                    SceneManager.LoadScene(targetSceneName);
                }
            }
            else
            {
                if (root != null)
                {
                    root.style.display = DisplayStyle.None;
                }
            }
        }
    }

    public bool IsContentActive()
    {
        return uiDocument != null && root != null && root.style.display == DisplayStyle.Flex;
    }
}
