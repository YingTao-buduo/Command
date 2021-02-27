using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bRight : MonoBehaviour
{
    public Block right;
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
                    stepM.blockList.Add(right);
                    MainManager.CreateNewBlock(right);
                }
                break;
            case 1:
                if (step1.blockList.Count < 8)
                {
                    step1.blockList.Add(right);
                    Func1Manager.CreateNewBlock(right);
                }
                break;
            case 2:
                if (step2.blockList.Count < 8)
                {
                    step2.blockList.Add(right);
                    Func2Manager.CreateNewBlock(right);
                }
                break;
        }

    }
}
