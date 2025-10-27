using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaStartButton : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("SceneOne");
    }
}
