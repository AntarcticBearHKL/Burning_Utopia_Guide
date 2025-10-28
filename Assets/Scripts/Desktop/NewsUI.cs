using UnityEngine;
using UnityEngine.UIElements;

public class NewsUI : MonoBehaviour
{
    private VisualElement closeElement;
    private EventCallback<MouseUpEvent> closeCallback;

    void OnEnable()
    {
        var doc = transform.parent != null ? transform.parent.GetComponentInChildren<UIDocument>() : GetComponentInChildren<UIDocument>();
        if (doc == null) return;
        closeElement = doc.rootVisualElement.Q<VisualElement>("CloseButton");
        if (closeElement == null) return;
        closeCallback = (MouseUpEvent evt) =>
        {
            gameObject.SetActive(false);
        };
        closeElement.RegisterCallback<MouseUpEvent>(closeCallback);
    }

    void OnDisable()
    {
        if (closeElement != null && closeCallback != null)
        {
            closeElement.UnregisterCallback<MouseUpEvent>(closeCallback);
            closeElement = null;
            closeCallback = null;
        }
    }
}
