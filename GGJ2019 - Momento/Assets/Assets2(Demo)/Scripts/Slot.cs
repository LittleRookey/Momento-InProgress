using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour {

    //public GameObject infoWindowPanel;
    //public Text SlotInfo;
    private string itemName;
    private ItemManager itemManager;

    public GameObject informationWindow;
    public Text informationText;

    private void Awake()
    {
        itemManager = FindObjectOfType<ItemManager>();
        informationWindow.SetActive(false);
    }

    public void ShowInformation(int id) {
        if (FindObjectOfType<PlayerBag>().playerBag[id] != null && transform.Find("Image").GetComponent<Image>().sprite != null)
        {
            itemName = FindObjectOfType<PlayerBag>().playerBag[id].name;
            Debug.Log(itemName);

            for (int i = 0; i < itemManager.items.Length; i++) {
                if(itemManager.items[i].itemName == itemName) {//Comment These two itenName are different
                    Debug.Log(itemManager.items[i].itemDescription);
                    //Instantiate(informationWindow, transform.position + new Vector3(0.0f, -20.0f, 0.0f), Quaternion.identity);//Comment fail
                    informationText.text = itemManager.items[i].itemDescription;
                }
            }
        }
    }

    public void MouseHover()
    {
        informationWindow.SetActive(true);
    }

    public void MouseExit()
    {
        informationWindow.SetActive(false);
    }

}
