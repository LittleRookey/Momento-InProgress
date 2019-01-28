using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBag : MonoBehaviour {

    public List<GameObject> playerBag = new List<GameObject>();
    public GameObject[] slots;

    private void Awake()
    {
        
    }

    private void Update()
    {
        ShowItemInSlot();
    }

    private void ShowItemInSlot() {
        for (int i = 0; i < slots.Length; i++) {

            if(playerBag[i] != null) {
                slots[i].transform.Find("Image").GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
                slots[i].transform.Find("Image").GetComponent<Image>().sprite = playerBag[i].GetComponent<SpriteRenderer>().sprite;
            }
        }
    }
    

}
