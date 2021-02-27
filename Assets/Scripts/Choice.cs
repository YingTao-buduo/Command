using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice : MonoBehaviour
{
    static Choice instance_C;

    public static int choice = 0;
    void Awake()
    {
        if (instance_C != null)
        {
            Destroy(this);
        }
        instance_C = this;
    }
}
