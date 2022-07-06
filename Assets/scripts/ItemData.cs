using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class ItemData : ScriptableObject
{
    public string name;
    public int quantityPerSlot;
    public Sprite spriteIcon;
    public GameObject prefab;
}
