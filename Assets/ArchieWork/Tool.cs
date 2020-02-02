using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : Item
{
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
            pi.setItem(this);
            gameObject.SetActive(false);

          //  Debug.Log($"Obtained Tool: {this.name}");
        }

        //else
          //  Debug.Log("Cannot pick up another object...");
    }
}
