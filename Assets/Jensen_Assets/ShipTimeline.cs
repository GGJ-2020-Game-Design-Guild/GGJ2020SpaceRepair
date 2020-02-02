using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipTimeline : MonoBehaviour
{
    ShipEventManager eventManagerScript;
    MarriageMeter shipMarriageMeter;

    void Start()
    {
        eventManagerScript = FindObjectOfType<ShipEventManager>();

        Invoke("event1", 30.0f);
        Invoke("event1", 60.0f);
        Invoke("event1", 90.0f);
        Invoke("event1", 120.0f);
        Invoke("event1", 150.0f);
        Invoke("event1", 180.0f);
        Invoke("event1", 210.0f);
        Invoke("event1", 240.0f);
        Invoke("event1", 270.0f);
        Invoke("event1", 300.0f);
        //10
        Invoke("event1", 330.0f);
        Invoke("event1", 360.0f);
        Invoke("event1", 390.0f);
        Invoke("event1", 420.0f);
        Invoke("event1", 450.0f);
        Invoke("event1", 480.0f);
        Invoke("event1", 510.0f);
        Invoke("event1", 540.0f);
        Invoke("event1", 570.0f);
        Invoke("event1", 600.0f);
        //20
        Invoke("event1", 630.0f);
        Invoke("event1", 660.0f);
        Invoke("event1", 690.0f);





        //Final Game end invoke
        //750 seconds long game, 12 minutes
        Invoke("finalEvent", 750.0f);
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



    void finalEvent()
    {
        SceneManager.LoadScene(2);
    }

}
