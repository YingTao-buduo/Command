using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyBack : MonoBehaviour
{
    public Step mStep;
    public void onClicked()
    {
        mStep.blockList.Clear();
        SceneManager.LoadScene("Easy");
    }
}
