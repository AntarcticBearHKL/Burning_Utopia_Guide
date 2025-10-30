using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class BlackManagerInit : MonoBehaviour
{
    public GameObject videoPlayerObject;
    private VideoPlayer videoPlayer;

    void Start()
    {
        if (videoPlayerObject != null)
        {
            videoPlayer = videoPlayerObject.GetComponent<VideoPlayer>();
            
            if (videoPlayer != null)
            {
                videoPlayer.loopPointReached += OnVideoFinished;
                
                videoPlayer.Play();
            }
            else
            {
                Debug.LogError("在指定的GameObject上未找到VideoPlayer组件！");
            }
        }
        else
        {
            Debug.LogError("未分配VideoPlayer所在的GameObject，请在Inspector中分配！");
        }
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        SceneManager.LoadScene("Intro");
    }

    void OnDestroy()
    {
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached -= OnVideoFinished;
        }
    }
}
