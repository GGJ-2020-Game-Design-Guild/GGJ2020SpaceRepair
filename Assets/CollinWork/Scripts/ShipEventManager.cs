using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShipEventManager : MonoBehaviour
{
    // Lists of ship machinery, parts, and tools.
    public List<string> shipMachinery;
    public List<string> shipParts;
    public List<string> tools;

    // Start is called before the first frame update
    void Start()
    {
        shipMachinery.Add("shipMachine1");
        shipMachinery.Add("shipMachine2");
        shipMachinery.Add("shipMachine3");

        shipParts.Add("shipPart1");
        shipParts.Add("shipPart2");
        shipParts.Add("shipPart3");

        tools.Add("tool1");
        tools.Add("tool2");
        tools.Add("tool3");
    }

    public void damageSelection()
    {
        Debug.Log(shipMachinery[Random.Range(0, shipMachinery.Count)]);
        Debug.Log(shipParts[Random.Range(0, shipParts.Count)]);
        Debug.Log(tools[Random.Range(0, tools.Count)]);
    }
}
