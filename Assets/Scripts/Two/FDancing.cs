using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FDancing : MonoBehaviour
{
    public List<Sprite> sprites;
    public float playInterval = 0.5f;

    private SpriteRenderer spriteRenderer;
    private int currentIndex = 0;
    private float timer = 0f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            enabled = false;
            return;
        }
        if (sprites != null && sprites.Count > 0)
        {
            spriteRenderer.sprite = sprites[0];
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (sprites == null || sprites.Count == 0) return;
        if (timer >= playInterval)
        {
            timer = 0f;
            currentIndex = (currentIndex + 1) % sprites.Count;
            spriteRenderer.sprite = sprites[currentIndex];
        }
    }
}
