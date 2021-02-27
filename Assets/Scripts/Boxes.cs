using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    void Update()
    {
        Transform[] boxes = GameObject.Find("Boxes").GetComponentsInChildren<Transform>();
        if (boxes.Length == 1)
        {
            GameObject.Find("roboto").tag = "Robot";
        }
    }
}
