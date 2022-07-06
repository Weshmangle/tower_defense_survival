using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    protected int numberSlots = 10;

    [SerializeField]
    protected Slot[] slots;

    [SerializeField]
    protected Transform slotsInventory;
    
    void Start()
    {
        slots = new Slot[numberSlots];
        for (var i = 0; i < numberSlots; i++)
        {
            GameObject go = new GameObject();
            go.name = $"slot_{i}";
            go.transform.parent = slotsInventory.transform;
            slots[i] = go.AddComponent<Slot>();
        }
    }

    public bool AddItem(Item item)
    {
        if(item == null) return false;

        Slot slotEmpty = null;

        foreach (var slot in slots)
        {
            if(slot.SlotIsEmpty())
            {
                slotEmpty = slot;
            }
            else
            {
                if(slot.GetItemData().name == item.GetData().name)
                {
                    if(!slot.SlotIsFull())
                    {
                        return slot.AddItem(item.GetData());
                    }
                }
            }
        }

        if(slotEmpty != null)
        {
            slotEmpty.AddItem(item.GetData());
        }

        return false;        
    }
}