using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTimeline : MonoBehaviour
{
    ShipEventManager eventManagerScript;

    void Start()
    {
        eventManagerScript = FindObjectOfType<ShipEventManager>();

        Invoke("event1", 10.0f);
        Invoke("event2", 20.0f);
        Invoke("event3", 30.0f);
    }

    void event1()
    {
        eventManagerScript.damageSelection();
    }

    void event2()
    {
        eventManagerScript.damageSelection();

    }

    void event3()
    {
        eventManagerScript.damageSelection();
    }

}
