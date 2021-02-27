using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bClear : MonoBehaviour
{
    public Step stepM;
    public Step step1;
    public Step step2;

    public void onClicked()
    {
        MainManager.idList.Clear();
        stepM.blockList.Clear();
        Func1Manager.idList.Clear();
        step1.blockList.Clear();
        Func2Manager.idList.Clear();
        step2.blockList.Clear();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
