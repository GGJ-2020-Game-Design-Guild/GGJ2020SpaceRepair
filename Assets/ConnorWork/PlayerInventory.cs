using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Item item;
    Texture2D heldItemSprite;
    string heldItemName;
    public int facing;
    public BoxCollider2D interactCollider;
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

        //UP
        if (facing == 0)
        {
            interactCollider.transform.localPosition = new Vector3(0, 1, 0);
        }

        //RIGHT
        if (facing == 1)
        {
            interactCollider.transform.localPosition = new Vector3(1, 0, 0);
        }

        //DOWN
        if (facing == 2)
        {
            interactCollider.transform.localPosition = new Vector3(0, -1, 0);
        }

        //LEFT
        if (facing == 3)
        {
            interactCollider.transform.localPosition = new Vector3(-1, 0, 0);
        }

        if (Input.GetButtonDown("Jump")) {
            interact();
        }
    }

    public void setItem(Item i) {
        item = i;
        heldItemSprite = i.sprite;
        heldItemName = i.name;
    }

    public void interact() {
       

        interactCollider.GetComponent<ColliderTrigger>().interactable.gameObject.SendMessage("interact",this );

    }
}
