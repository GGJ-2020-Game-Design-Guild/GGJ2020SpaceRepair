using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiphealthMap : MonoBehaviour
{

    public List<GameObject> ShipPartsDisplay;

    public GameObject ShipManager;

    float dummyInt;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*for(int i = 0; i<ShipManager.GetComponent<ShipEventManager>().shipParts.Count; i++)
        {
            dummyInt = ShipManager.GetComponent<ShipEventManager>().shipParts[i].GetComponent<ShipPart>().health;
            ShipPartsDisplay[i].GetComponent<DisplayHealth>().health = dummyInt;
        }*/

    }
}
