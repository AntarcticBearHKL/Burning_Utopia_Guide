using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesktopStart : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        if (animator != null)
        {
            animator.enabled = false;
        }
    }

    void OnMouseDown()
    {
        if (animator != null)
        {
            animator.enabled = true;
            animator.Play("AnimationName");
            StartCoroutine(HideAnimatorObjectAfterAnimation());
        }
    }

    private IEnumerator HideAnimatorObjectAfterAnimation()
    {
        if (animator != null)
        {
            yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
            animator.gameObject.SetActive(false);
        }
    }
}
