using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShipEventManager : MonoBehaviour
{
    // Lists of ship machinery, parts, and tools.
    public List<GameObject> shipParts;
    public List<Item> shipItems;
    public List<Tool> tools;

    public GameObject assignedPart;
    public Item assignedItem;
    public Tool assignedTool;

    // Start is called before the first frame update
    void Start()
    {
        //shipParts.Add();
        ////shipParts.Add();
        ////shipParts.Add();
        //
        //shipItems.Add();
        //shipItems.Add();
        //shipItems.Add();
        //shipItems.Add();
        //shipItems.Add();
        //
        //tools.Add();
        //tools.Add();
        //tools.Add();
        //tools.Add();
        //tools.Add();
    }

    public void damageSelection()
    {
        assignedPart = shipParts[Random.Range(0, shipParts.Count)];
        assignedItem = shipItems[Random.Range(0, shipItems.Count)];
        assignedTool = tools[Random.Range(0, tools.Count)];
        assignedPart.GetComponent<ShipPart>().damage();
    }
}
