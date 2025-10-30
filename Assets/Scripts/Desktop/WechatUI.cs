using UnityEngine;
using UnityEngine.UIElements;

public class WechatUI : MonoBehaviour
{
    private VisualElement closeElement;
    private VisualElement f1Button, f2Button, f3Button, c1Control, c2Control, c3Control;
    private EventCallback<MouseUpEvent> closeCallback;
    private EventCallback<ClickEvent> f1Callback, f2Callback, f3Callback;

    public VisualTreeAsset uxmlAsset;


    void OnEnable()
    {
        var doc = transform.parent != null ? transform.parent.GetComponentInChildren<UIDocument>() : GetComponentInChildren<UIDocument>();
        if (doc == null) return;
        closeElement = doc.rootVisualElement.Q<VisualElement>("CloseButton");
        f1Button = doc.rootVisualElement.Q<VisualElement>("F1");
        f2Button = doc.rootVisualElement.Q<VisualElement>("F2");
        f3Button = doc.rootVisualElement.Q<VisualElement>("F3");
        c1Control = doc.rootVisualElement.Q<VisualElement>("C1");
        c2Control = doc.rootVisualElement.Q<VisualElement>("C2");
        c3Control = doc.rootVisualElement.Q<VisualElement>("C3");
        if (closeElement == null) return;
        closeCallback = (MouseUpEvent evt) =>
        {
            gameObject.SetActive(false);
        };
        closeElement.RegisterCallback<MouseUpEvent>(closeCallback);

        f1Callback = (ClickEvent evt) => SetActiveControl(1);
        f2Callback = (ClickEvent evt) => SetActiveControl(2);
        f3Callback = (ClickEvent evt) => SetActiveControl(3);

        if (f1Button != null) f1Button.RegisterCallback<ClickEvent>(f1Callback);
        if (f2Button != null) f2Button.RegisterCallback<ClickEvent>(f2Callback);
        if (f3Button != null) f3Button.RegisterCallback<ClickEvent>(f3Callback);
    }

    void Start()
    {
        if (c1Control != null) c1Control.style.opacity = 1;
        if (c2Control != null) c2Control.style.opacity = 0;
        if (c3Control != null) c3Control.style.opacity = 0;
    }

    void OnDisable()
    {
        if (closeElement != null && closeCallback != null)
        {
            closeElement.UnregisterCallback<MouseUpEvent>(closeCallback);
            closeElement = null;
            closeCallback = null;
        }
        if (f1Button != null && f1Callback != null) f1Button.UnregisterCallback<ClickEvent>(f1Callback);
        if (f2Button != null && f2Callback != null) f2Button.UnregisterCallback<ClickEvent>(f2Callback);
        if (f3Button != null && f3Callback != null) f3Button.UnregisterCallback<ClickEvent>(f3Callback);
        f1Button = null; f2Button = null; f3Button = null;
        f1Callback = null; f2Callback = null; f3Callback = null;
    }

    private void SetActiveControl(int index)
    {
        if (c1Control != null) c1Control.style.opacity = index == 1 ? 1 : 0;
        if (c2Control != null) c2Control.style.opacity = index == 2 ? 1 : 0;
        if (c3Control != null) c3Control.style.opacity = index == 3 ? 1 : 0;
    }
}
