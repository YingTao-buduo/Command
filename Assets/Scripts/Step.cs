using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Step", menuName = "Step/New Step")]
public class Step : ScriptableObject
{
    public List<Block> blockList = new List<Block>();
}
