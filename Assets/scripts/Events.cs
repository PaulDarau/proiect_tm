using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class Events : MonoBehaviour
{
    
    public void ReplayGame()
    {
        SceneManager.LoadScene("Level"); 
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}