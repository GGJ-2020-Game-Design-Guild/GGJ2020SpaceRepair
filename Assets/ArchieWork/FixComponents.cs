using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixComponents : MonoBehaviour
{

    public bool hasItem = false;
    public Item requiredItem;
    public Tool requiredTool;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        requiredItem = GetComponent<ShipPart>().requiredItem;
        requiredTool = GetComponent<ShipPart>().requiredTool;
    }

    ///
    void ToolInteract()
    {

    }

    void ItemInteract()
    {

    }

    ///
}
