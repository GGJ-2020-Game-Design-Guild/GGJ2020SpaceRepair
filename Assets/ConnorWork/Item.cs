using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Interactable
{
    public string name;
    public Texture2D sprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void interact(PlayerInventory pi) {
        if (pi.item == null) {
            pi.setItem(this);
            gameObject.SetActive(false);
        }
    }

}
