using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
    public Interactable interactable;
    public UIMove ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ui.show = false;
        if (interactable) {
            if (interactable is ShipPart)
            {
                ShipPart i = (ShipPart)interactable;
                if (i.requiredItem != null)
                {
                    ui.item.sprite = i.requiredItem.GetComponent<SpriteRenderer>().sprite;
                    ui.tool.sprite = i.requiredTool.GetComponent<SpriteRenderer>().sprite;
                    ui.show = true;
                }
            }


        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Interactable i = collision.GetComponent<Interactable>();
        if (i) {
            interactable = collision.GetComponent<Interactable>();
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (interactable)
        {
            if (collision == interactable.GetComponent<Collider2D>())
            {
                interactable = null;
            }
        }
    }
}
