using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FDancing : MonoBehaviour
{
    [Header("Sprite 设置")]
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;

    [Header("播放设置")]
    public float playInterval = 0.5f; // 每张图片播放的时间间隔（秒）

    private SpriteRenderer spriteRenderer;
    private Sprite[] sprites;
    private int currentIndex = 0;
    private float timer = 0f;

    void Start()
    {
        // 获取 SpriteRenderer 组件
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        if (spriteRenderer == null)
        {
            Debug.LogError("FDancing: 未找到 SpriteRenderer 组件！");
            enabled = false;
            return;
        }

        // 将四张图片放入数组
        sprites = new Sprite[] { sprite1, sprite2, sprite3, sprite4 };

        // 检查是否所有 Sprite 都已设置
        foreach (Sprite spr in sprites)
        {
            if (spr == null)
            {
                Debug.LogWarning("FDancing: 有 Sprite 未设置，请在 Inspector 中设置所有四张图片！");
            }
        }

        // 显示第一张图片
        if (sprite1 != null)
        {
            spriteRenderer.sprite = sprite1;
        }
    }

    void Update()
    {
        // 累加时间
        timer += Time.deltaTime;

        // 当时间超过间隔时，切换到下一张图片
        if (timer >= playInterval)
        {
            timer = 0f;
            
            // 切换到下一张图片
            currentIndex = (currentIndex + 1) % sprites.Length;
            
            // 更新显示的图片
            if (sprites[currentIndex] != null)
            {
                spriteRenderer.sprite = sprites[currentIndex];
            }
        }
    }
}
