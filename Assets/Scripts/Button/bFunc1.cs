using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bFunc1 : MonoBehaviour
{
    public Block fun1;
    public Step stepM;
    public Step step1;
    public Step step2;
    AudioSource btn;

    public void onClicked()
    {
        btn = GameObject.Find("BTN").GetComponent<AudioSource>();
        btn.Play();
        switch (Choice.choice)
        {
            case 0:
                if (stepM.blockList.Count < 8)
                {
                    stepM.blockList.Add(fun1);
                    MainManager.CreateNewBlock(fun1);
                }
                break;
            case 1:
                if (step1.blockList.Count < 8)
                {
                    step1.blockList.Add(fun1);
                    Func1Manager.CreateNewBlock(fun1);
                }
                break;
            case 2:
                if (step2.blockList.Count < 8)
                {
                    step2.blockList.Add(fun1);
                    Func2Manager.CreateNewBlock(fun1);
                }
                break;
        }

    }
}
