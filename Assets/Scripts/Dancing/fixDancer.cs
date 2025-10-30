using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixDancer : MonoBehaviour
{
    public int musicIndex = 1;
    public GameObject musicPlayerGO;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        musicPlayerGO.GetComponent<musicPlayer>().Play(musicIndex);
    }
}
