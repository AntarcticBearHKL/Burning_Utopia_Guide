using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicPlayer : MonoBehaviour
{
    public List<AudioClip> musicList = new List<AudioClip>();
    public GameObject audioSourceGO1;
    public GameObject audioSourceGO2;
    private AudioSource audioSource;
    private float originalVolume1;
    private float originalVolume2;
    private bool isPlaying = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (isPlaying && !audioSource.isPlaying)
        {
            RestoreVolumes();
            isPlaying = false;
        }
    }

    public void Play(int index)
    {
        if (index >= 1 && index <= musicList.Count)
        {
            if (audioSourceGO1 != null)
            {
                originalVolume1 = audioSourceGO1.GetComponent<AudioSource>().volume;
                audioSourceGO1.GetComponent<AudioSource>().volume = 0.1f;
            }
            if (audioSourceGO2 != null)
            {
                originalVolume2 = audioSourceGO2.GetComponent<AudioSource>().volume;
                audioSourceGO2.GetComponent<AudioSource>().volume = 0.1f;
            }
            audioSource.clip = musicList[index - 1];
            audioSource.Play();
            isPlaying = true;
        }
    }

    public void Stop()
    {
        audioSource.Stop();
        RestoreVolumes();
        isPlaying = false;
    }

    private void RestoreVolumes()
    {
        if (audioSourceGO1 != null) audioSourceGO1.GetComponent<AudioSource>().volume = originalVolume1;
        if (audioSourceGO2 != null) audioSourceGO2.GetComponent<AudioSource>().volume = originalVolume2;
    }
}
