using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartBox : Interactable
{
    public Item item;
    public Texture2D sprite;

    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }
}
