using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour
{
    // Start is called before the first frame update
    public void start()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void quit()
    {
        Application.Quit();
    }

    public void learn()
    {
        SceneManager.LoadScene("Study");
    }
}
