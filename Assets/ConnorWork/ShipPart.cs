using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPart : Interactable
{
    const float MAX_HEALTH = 100;
    public float health;

    public bool hasItem = false;

    public GameObject requiredItem;
    public GameObject requiredTool;
    
    // Start is called before the first frame update
    void Start()
    {
        health = MAX_HEALTH;
        Debug.Log($"Required Item: {requiredItem}, Required Tool: {requiredTool}");
    }

    // Update is called once per frame
    void Update()
    {
        requiredItem = FindObjectOfType<ShipEventManager>().assignedItem;
        requiredTool = FindObjectOfType<ShipEventManager>().assignedTool;
    }

    override public void interact(PlayerInventory pi) {

        if (pi.item == requiredTool && hasItem)
        {
            health = MAX_HEALTH;
        }
    }

    public void damage() {
        health -= 10;
        if (health <= 0) {
            //something bad
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);

        if (requiredItem == collision.gameObject)
        {
            hasItem = true;
            collision.gameObject.SetActive(false);
            Debug.Log("Henlo BitchAss");
        }

    }

}
