﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName="New Item",menuName="Item")]
public class Item : ScriptableObject
{
    public string itemName = "";
    public string itemDesc = "";
    public Texture2D itemThumbnail;
    public int itemWidth;
    public int itemHeight;
    public float itemRotation;
    public InventoryItem inventoryItem;
    public GameObject baseObj;
    public GameObject instancedObj = null;
    public Storage currentStorage;
    public int slotX;
    public int slotY;

    //Save last storage information
    public Storage previousStorage;
    public int prevSlotX;
    public int prevSlotY;
}