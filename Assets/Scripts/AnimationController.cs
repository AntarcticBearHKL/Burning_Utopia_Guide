using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Sprite[] upAnimationSprites;
    [SerializeField] private Sprite[] downAnimationSprites;
    [SerializeField] private Sprite[] leftAnimationSprites;
    [SerializeField] private Sprite[] rightAnimationSprites;
    [SerializeField] private float frameRate = 10f;
    [SerializeField] private bool loopAnimation = true;
    [SerializeField] private float moveSpeed = 5f;
    
    private SpriteRenderer spriteRenderer;
    private Coroutine animationCoroutine;
    private bool isPlaying = false;
    private int currentFrameIndex = 0;
    private Sprite[] currentAnimationSprites;
    private bool isMoving = false;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("AnimationController需要SpriteRenderer组件");
            return;
        }
        
        if (downAnimationSprites != null && downAnimationSprites.Length > 0)
        {
            spriteRenderer.sprite = downAnimationSprites[0];
            currentAnimationSprites = downAnimationSprites;
        }
    }
    
    void Update()
    {
        HandleMovement();
        transform.rotation = Quaternion.identity;
        
        Vector3 pos = transform.position;
        pos.y = 0f;
        transform.position = pos;
    }
    
    private void HandleMovement()
    {
        Vector3 movement = Vector3.zero;
        bool hasInput = false;
        
        if (Input.GetKey(KeyCode.W))
        {
            movement.z += 1f;
            if (!isMoving || currentAnimationSprites != upAnimationSprites)
            {
                PlayUp();
            }
            hasInput = true;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement.z -= 1f;
            if (!isMoving || currentAnimationSprites != downAnimationSprites)
            {
                PlayDown();
            }
            hasInput = true;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movement.x -= 1f;
            if (!isMoving || currentAnimationSprites != leftAnimationSprites)
            {
                PlayLeft();
            }
            hasInput = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement.x += 1f;
            if (!isMoving || currentAnimationSprites != rightAnimationSprites)
            {
                PlayRight();
            }
            hasInput = true;
        }
        
        if (hasInput)
        {
            movement = movement * moveSpeed * Time.deltaTime;
            transform.position += movement;
            isMoving = true;
        }
        else
        {
            if (isMoving)
            {
                Stop();
                isMoving = false;
            }
        }
    }
    
    public void PlayUp()
    {
        PlayAnimation(upAnimationSprites, "向上");
    }
    
    public void PlayDown()
    {
        PlayAnimation(downAnimationSprites, "向下");
    }
    
    public void PlayLeft()
    {
        PlayAnimation(leftAnimationSprites, "向左");
    }
    
    public void PlayRight()
    {
        PlayAnimation(rightAnimationSprites, "向右");
    }
    
    private void PlayAnimation(Sprite[] sprites, string direction)
    {
        if (sprites == null || sprites.Length == 0)
        {
            Debug.LogWarning($"没有设置{direction}动画sprite数组！");
            return;
        }
        
        if (spriteRenderer == null)
        {
            Debug.LogError("没有找到SpriteRenderer组件！");
            return;
        }
        
        if (currentAnimationSprites != sprites)
        {
            if (isPlaying)
            {
                StopCoroutine(animationCoroutine);
            }
            
            currentAnimationSprites = sprites;
            currentFrameIndex = 0;
            isPlaying = true;
            animationCoroutine = StartCoroutine(PlayAnimationCoroutine());
        }
        else if (!isPlaying)
        {
            isPlaying = true;
            animationCoroutine = StartCoroutine(PlayAnimationCoroutine());
        }
    }
    
    public void Stop()
    {
        if (isPlaying)
        {
            isPlaying = false;
            if (animationCoroutine != null)
            {
                StopCoroutine(animationCoroutine);
                animationCoroutine = null;
            }
            
            currentFrameIndex = 0;
            if (currentAnimationSprites != null && currentAnimationSprites.Length > 0)
            {
                spriteRenderer.sprite = currentAnimationSprites[0];
            }
        }
    }
    
    public void Pause()
    {
        if (isPlaying)
        {
            isPlaying = false;
            if (animationCoroutine != null)
            {
                StopCoroutine(animationCoroutine);
                animationCoroutine = null;
            }
        }
    }
    
    public void Resume()
    {
        if (!isPlaying && currentAnimationSprites != null && currentAnimationSprites.Length > 0)
        {
            isPlaying = true;
            animationCoroutine = StartCoroutine(PlayAnimationCoroutine());
        }
    }
    
    private IEnumerator PlayAnimationCoroutine()
    {
        float frameTime = 1f / frameRate;
        
        while (isPlaying && currentAnimationSprites != null)
        {
            spriteRenderer.sprite = currentAnimationSprites[currentFrameIndex];
            
            yield return new WaitForSeconds(frameTime);
            
            currentFrameIndex++;
            
            if (currentFrameIndex >= currentAnimationSprites.Length)
            {
                if (loopAnimation)
                {
                    currentFrameIndex = 0;
                }
                else
                {
                    Stop();
                    break;
                }
            }
        }
    }
    
    public bool IsPlaying()
    {
        return isPlaying;
    }
    
    public void SetFrameRate(float newFrameRate)
    {
        frameRate = Mathf.Max(0.1f, newFrameRate);
    }
    
    public void SetLoopAnimation(bool loop)
    {
        loopAnimation = loop;
    }
    
    public void SetMoveSpeed(float newMoveSpeed)
    {
        moveSpeed = Mathf.Max(0f, newMoveSpeed);
    }
}
