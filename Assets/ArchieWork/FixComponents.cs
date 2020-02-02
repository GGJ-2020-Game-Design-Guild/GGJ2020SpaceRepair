using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixComponents : MonoBehaviour
{

    public bool hasItem = false;
    public GameObject requiredItem;
    public GameObject requiredTool;

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
    void FixComponent()
    {
        
    }

    ///
}
