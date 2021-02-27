using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Block", menuName = "Step/New Block")]
public class Block : ScriptableObject
{
    public string blockName;
    public Sprite blockImage;
    public int id;
}
