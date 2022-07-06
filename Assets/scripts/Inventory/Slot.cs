using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    protected ItemData itemData;
    protected int quantity;

    public bool SlotIsFull()
    {
        return quantity >= itemData.quantityPerSlot;
    }

    public bool SlotIsEmpty()
    {
        return itemData == null;
    }

    public bool AddItem(ItemData item)
    {
        bool isFull = SlotIsFull();
        
        if(SlotIsEmpty())
        {
            this.itemData = item;
            this.quantity = 0;
        }

        if(!isFull)
        {
            quantity+=1;
        }

        return !isFull;
    }

    public bool RemoveItem()
    {
        bool empty = SlotIsEmpty();

        if(!empty)
        {
            this.quantity -= 1;
            
            if(this.quantity == 0)
            {
                itemData = null;
                quantity = 0;
            }
        }

        return !empty;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public ItemData GetItemData()
    {
        return itemData;
    }
}
