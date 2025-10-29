using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FAnimation : MonoBehaviour
{
    public List<Sprite> spriteList = new List<Sprite>();
    public float playInterval = 0.5f;

    private SpriteRenderer parentSpriteRenderer;
    private int currentIndex = 0;
    private float timer = 0f;

    void Start()
    {
        parentSpriteRenderer = GetComponent<SpriteRenderer>();
        
        if (spriteList.Count > 0 && spriteList[0] != null)
        {
            parentSpriteRenderer.sprite = spriteList[0];
        }
    }

    void Update()
    {
        if (spriteList.Count == 0) return;

        timer += Time.deltaTime;

        if (timer >= playInterval)
        {
            timer = 0f;
            currentIndex = (currentIndex + 1) % spriteList.Count;
            
            if (spriteList[currentIndex] != null)
            {
                parentSpriteRenderer.sprite = spriteList[currentIndex];
            }
        }
    }
}
