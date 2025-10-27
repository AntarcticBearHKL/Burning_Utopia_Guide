using UnityEngine;
using UnityEngine.UIElements;

public class WechatUI : MonoBehaviour
{
    void Start()
    {
        var doc = transform.parent != null ? transform.parent.GetComponentInChildren<UIDocument>() : GetComponentInChildren<UIDocument>();
        if (doc == null) return;
        var close = doc.rootVisualElement.Q<VisualElement>("CloseButton");
        if (close == null) return;
        close.RegisterCallback<MouseUpEvent>(_ =>
        {
            gameObject.SetActive(false);
        });
    }
}
