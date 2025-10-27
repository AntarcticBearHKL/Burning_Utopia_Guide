using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

public class FadeEffect : MonoBehaviour
{
    [SerializeField]
    private string bgElementName = "EFFECT";

    private VisualElement bgVisualElement;

    void Start()
    {
        var uiDocument = GetComponent<UIDocument>();
        if (uiDocument == null) return;
        var root = uiDocument.rootVisualElement;
        if (root == null) return;
        bgVisualElement = root.Q(bgElementName);
    }

    public async Task FadeInAsync(float duration)
    {
        if (bgVisualElement == null) return;
        float elapsed = 0f;
        bgVisualElement.style.opacity = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            bgVisualElement.style.opacity = Mathf.Clamp01(elapsed / duration);
            await Task.Yield();
        }
        bgVisualElement.style.opacity = 1f;
    }

    public async Task FadeOutAsync(float duration)
    {
        if (bgVisualElement == null) return;
        float elapsed = 0f;
        bgVisualElement.style.opacity = 1f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            bgVisualElement.style.opacity = Mathf.Clamp01(1f - (elapsed / duration));
            await Task.Yield();
        }
        bgVisualElement.style.opacity = 0f;
    }
}
