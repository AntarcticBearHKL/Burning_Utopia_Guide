using UnityEngine;
using UnityEngine.UIElements;
using System.Collections.Generic;

public class NewsUI : MonoBehaviour
{
    private VisualElement closeElement;
    private List<VisualElement> newsList;
    private VisualElement prevButton, nextButton;
    private EventCallback<MouseUpEvent> closeCallback;
    private EventCallback<ClickEvent> prevCallback, nextCallback;
    private int currentIndex = 0;

    void OnEnable()
    {
        var doc = transform.parent != null ? transform.parent.GetComponentInChildren<UIDocument>() : GetComponentInChildren<UIDocument>();
        if (doc == null) return;
        closeElement = doc.rootVisualElement.Q<VisualElement>("CloseButton");
        newsList = new List<VisualElement>();
        var n1 = doc.rootVisualElement.Q<VisualElement>("N1");
        if (n1 != null) newsList.Add(n1);
        var n2 = doc.rootVisualElement.Q<VisualElement>("N2");
        if (n2 != null) newsList.Add(n2);
        var n3 = doc.rootVisualElement.Q<VisualElement>("N3");
        if (n3 != null) newsList.Add(n3);
        prevButton = doc.rootVisualElement.Q<VisualElement>("Prev");
        nextButton = doc.rootVisualElement.Q<VisualElement>("Next");
        if (closeElement == null) return;
        closeCallback = (MouseUpEvent evt) =>
        {
            gameObject.SetActive(false);
        };
        closeElement.RegisterCallback<MouseUpEvent>(closeCallback);

        prevCallback = (ClickEvent evt) =>
        {
            currentIndex = (currentIndex - 1 + newsList.Count) % newsList.Count;
            UpdateDisplay();
        };
        nextCallback = (ClickEvent evt) =>
        {
            currentIndex = (currentIndex + 1) % newsList.Count;
            UpdateDisplay();
        };

        if (prevButton != null) prevButton.RegisterCallback<ClickEvent>(prevCallback);
        if (nextButton != null) nextButton.RegisterCallback<ClickEvent>(nextCallback);
    }

    void Start()
    {
        UpdateDisplay();
    }

    void OnDisable()
    {
        if (closeElement != null && closeCallback != null)
        {
            closeElement.UnregisterCallback<MouseUpEvent>(closeCallback);
            closeElement = null;
            closeCallback = null;
        }
        if (prevButton != null && prevCallback != null) prevButton.UnregisterCallback<ClickEvent>(prevCallback);
        if (nextButton != null && nextCallback != null) nextButton.UnregisterCallback<ClickEvent>(nextCallback);
        prevButton = null; nextButton = null;
        prevCallback = null; nextCallback = null;
    }

    private void UpdateDisplay()
    {
        for (int i = 0; i < newsList.Count; i++)
        {
            newsList[i].style.opacity = i == currentIndex ? 1 : 0;
        }
    }
}
