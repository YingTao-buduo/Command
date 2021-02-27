using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntoNormal_1 : MonoBehaviour
{
    public Step mStep;
    public Step step1;
    public Step step2;
    public void onClicked()
    {
        mStep.blockList.Clear();
        step1.blockList.Clear();
        step2.blockList.Clear();
        MainManager.idList.Clear();
        Func1Manager.idList.Clear();
        SceneManager.LoadScene("Normal_1");
    }
}
