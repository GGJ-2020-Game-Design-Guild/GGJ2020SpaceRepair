using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartBox : Interactable
{
    public Sprite sprite;
    public Item pbItem;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override public void interact(PlayerInventory pi)
    {
        if (pi.item == null)
        {
            pi.setItem(pbItem);
            //gameObject.SetActive(false);
            Debug.Log($"Obtained Part Box: Item {this.name}");
        }

        else
            Debug.Log($"Item already in inventory");
    }
}
