using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Func1Manager : MonoBehaviour
{
    static Func1Manager instance_1;

    public Step step;
    public GameObject slotGrid;
    public Slot slot;
    public static List<int> idList = new List<int>();

    void Awake()
    {
        if (instance_1 != null)
        {
            Destroy(this);
        }
        instance_1 = this;
    }

    public static void CreateNewBlock(Block block)
    {
        Slot newSlot = Instantiate(instance_1.slot, instance_1.slotGrid.transform.position, Quaternion.identity);
        newSlot.gameObject.transform.SetParent(instance_1.slotGrid.transform);
        newSlot.slotBlock = block;
        idList.Add(block.id);
        newSlot.slotImage.sprite = block.blockImage;
    }

    public static void Clear()
    {
        for (int i = 0; i < instance_1.slotGrid.transform.childCount; i++)
        {
            Destroy(instance_1.slotGrid.transform.GetChild(i).gameObject);
        }
        idList.Clear();
    }

    public static List<int> readId()
    {
        return Func1Manager.idList;
    }
}
