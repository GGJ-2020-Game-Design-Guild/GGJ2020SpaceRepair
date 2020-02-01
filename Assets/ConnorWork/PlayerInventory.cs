using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Item item;
    Texture2D heldItemSprite;
    string heldItemName;
    public int facing;
    // Start is called before the first frame update
    void Start()
    {
        facing = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f)
        {
            facing = 1;
        }

        if (Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            facing = 3;
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f)
        {
            facing = 0;
        }

        if (Input.GetAxisRaw("Vertical") < -0.5f)
        {
            facing = 2;
        }

        if (Input.GetButtonDown("")) {

        }
    }

    public void setItem(Item i) {
        item = i;
        heldItemSprite = i.sprite;
        heldItemName = i.name;
    }
}
