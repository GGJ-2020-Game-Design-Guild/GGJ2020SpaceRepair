using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartBox : Interactable
{
    public Item item;
    public Sprite sprite;

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
            pi.setItem(item);
            gameObject.SetActive(false);
            Debug.Log($"Obtained Part Box: Item {item.name}");
        }

        else
            Debug.Log($"Item already in inventory");
    }

    private void OnTriggerEnter2D(Collider2D collision)        
    {
        Debug.Log("Hello");
    }
}
