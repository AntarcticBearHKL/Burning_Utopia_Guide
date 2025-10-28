using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesManager : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    
    public GameObject fade;
    
    private async void Start()
    {
        bool back = PlayerPrefs.GetInt("back", 0) == 1;
        
        PlayerPrefs.DeleteKey("back");
        PlayerPrefs.Save();
        
        if (back)
        {
            Step3();
        }
        else
        {
            if (fade != null)
            {
                FadeEffect fadeEffect = fade.GetComponent<FadeEffect>();
                if (fadeEffect != null)
                {
                    await fadeEffect.FadeInAsync(1.0f);
                }
            }
            Step1();
        }
    }

    public void Step1()
    {
        object1.SetActive(true);
        object2.SetActive(false);
        object3.SetActive(false);
    }

    public void Step2()
    {
        object1.SetActive(false);
        object2.SetActive(true);
        object3.SetActive(false);
    }

    public void Step3()
    {
        object1.SetActive(false);
        object2.SetActive(false);
        object3.SetActive(true);
    }
}
