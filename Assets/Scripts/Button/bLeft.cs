using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bLeft : MonoBehaviour
{
    public Block left;
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
                    stepM.blockList.Add(left);
                    MainManager.CreateNewBlock(left);
                }
                break;
            case 1:
                if (step1.blockList.Count < 8)
                {
                    step1.blockList.Add(left);
                    Func1Manager.CreateNewBlock(left);
                }
                break;
            case 2:
                if (step2.blockList.Count < 8)
                {
                    step2.blockList.Add(left);
                    Func2Manager.CreateNewBlock(left);
                }
                break;
        }

    }
}
