using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaExitButton : MonoBehaviour
{
    void OnMouseDown()
    {
        PlayerPrefs.SetInt("back", 1); 
        PlayerPrefs.Save();
        
        SceneManager.LoadScene("Desktop");
    }
}
