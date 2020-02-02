using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShipEventManager : MonoBehaviour
{
    // Lists of ship machinery, parts, and tools.
    public List<GameObject> shipParts;
    public List<GameObject> shipItems;
    public List<GameObject> tools;

    public GameObject assignedPart;
    public GameObject assignedItem;
    public GameObject assignedTool;

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
    }
}
