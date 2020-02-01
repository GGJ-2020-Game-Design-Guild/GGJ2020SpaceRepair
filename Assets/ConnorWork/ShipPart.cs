using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPart : Interactable
{
    const float MAX_HEALTH = 100;
    public float health;
    
    // Start is called before the first frame update
    void Start()
    {
        health = MAX_HEALTH;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override public void interact(PlayerInventory pi) {
        health = MAX_HEALTH;
    }

    public void damage() {
        health -= 10;
        if (health <= 0) {
            //something bad
        }
    }
}
