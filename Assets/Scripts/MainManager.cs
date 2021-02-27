using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    static MainManager instance;

    public Step step;
    public GameObject slotGrid;
    public Slot slot;
    public static List<int> idList = new List<int>();

    void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        instance = this;
    }

    public static void CreateNewBlock(Block block)
    {
        Slot newSlot = Instantiate(instance.slot, instance.slotGrid.transform.position, Quaternion.identity);
        newSlot.gameObject.transform.SetParent(instance.slotGrid.transform);
        newSlot.slotBlock = block;
        idList.Add(block.id);
        newSlot.slotImage.sprite = block.blockImage;
    }

    public static void Clear()
    {
        for (int i = 0; i < instance.slotGrid.transform.childCount; i++)
        {
            Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
        }
        idList.Clear();
    }

    public static List<int> readId()
    {
        return MainManager.idList;
    }
}
