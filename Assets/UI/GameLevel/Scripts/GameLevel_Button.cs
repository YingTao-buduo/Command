using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLevel_Button : MonoBehaviour
{
   public void back()
    {
        SceneManager.LoadScene("Start");
    }

    public void easy()
    {
        SceneManager.LoadScene("Easy");
    }

    public void normal()
    {
        SceneManager.LoadScene("Normal");
    }

    public void hard()
    {
        SceneManager.LoadScene("Hard");
    }
}
