using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{

    #region
    [System.Serializable]
    public class Item
    {

        public string itemName;
        public int itemID;
        public Sprite itemSprite;
        [TextArea]
        public string itemDescription;
    }
    #endregion

    [Header("All information of the items")]
    public Item[] items;

    [Header("All item GameObject Prefab")]
    public GameObject[] itemPrefab;


}
