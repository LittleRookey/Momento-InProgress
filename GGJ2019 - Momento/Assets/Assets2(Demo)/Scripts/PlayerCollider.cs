using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour {

    private ItemManager itemManager;
    public Animator anim;//comment this is the top tip name window animation
    public Text itemNameText;

    public Animator textAnim;//comment this is the top right Text animation
    public Image getIconImage;
    public Text getItemNameText;

    private void Awake()
    {
        itemManager = FindObjectOfType<ItemManager>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Item")) {
            //Debug.Log("TOUCH");

            for (int i = 0; i < itemManager.itemPrefab.Length; i++) {
                if(other.gameObject.name == itemManager.itemPrefab[i].name) {
                    Debug.Log("I touch item name is " + other.name);
                    Debug.Log(other.gameObject);
                    StartCoroutine(ShowItemName(other.name));

                    if (Input.GetKeyDown(KeyCode.Space))//pick up action
                    {
                        FindObjectOfType<PlayerBag>().playerBag.Add(other.gameObject);
                        //Destroy(other.gameObject);
                        other.gameObject.GetComponent<SpriteRenderer>().color = new Vector4(255, 255, 255, 0);
                        other.gameObject.GetComponent<PolygonCollider2D>().enabled = false;

                        StartCoroutine(ShowGetItemName(other.name));
                    }
                }
            }

        }
    }

    IEnumerator ShowItemName(string _itemName) {
        itemNameText.text = _itemName;
        anim.SetBool("isActive", true);
        yield return new WaitForSeconds(2.5f);
        anim.SetBool("isActive", false);
    }

    IEnumerator ShowGetItemName(string _item) {
        //getIconImage.GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
        getItemNameText.text = _item;
        textAnim.SetBool("isActive", true);
        yield return new WaitForSeconds(2.0f);
        //getIconImage.GetComponent<Image>().color = new Vector4(255, 255, 255, 0);
        textAnim.SetBool("isActive", false);
        getItemNameText.text = "";
    }

}
