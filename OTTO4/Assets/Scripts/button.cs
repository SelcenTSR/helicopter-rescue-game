using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class button : MonoBehaviour
{
   
   
    
    public void tryagain()
    {

        Time.timeScale = 1.0f;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/level1");
        if (PlayerPrefs.GetInt("level") == 2)
        {
            Time.timeScale = 1.0f;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/level2");
        }
        if (PlayerPrefs.GetInt("level") == 3)
        {
            Time.timeScale = 1.0f;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/level3");

        }
        if (PlayerPrefs.GetInt("level") == 4)
        {
            Time.timeScale = 1.0f;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/level4");
        }
    }
    public void nextlevel()
    {

        PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);

        Time.timeScale = 1.0f;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/level2");
    }

    public void nextlevel1()
    {
        PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
       
        Time.timeScale = 1.0f;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/level3");
    }
    public void nextlevel2()
    {
        PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
      
        Time.timeScale = 1.0f;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/level4");
    }


    // Update is called once per frame

}
