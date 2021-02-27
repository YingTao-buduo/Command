using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalBack : MonoBehaviour
{
    public void onClicked()
    {
        SceneManager.LoadScene("Normal");
    }
}
