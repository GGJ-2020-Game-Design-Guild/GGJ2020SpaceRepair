using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarriageMeter : MonoBehaviour
{
    public int marriageMeter = 0;
    ///public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (marriageMeter > 100)
        {
            marriageMeter = 100;
        }

        if (marriageMeter <= 0)
        {
            if (GameObject.FindGameObjectWithTag("DioTrigger") || GameObject.FindGameObjectWithTag("WalkTalk"))
            {
                GameObject.FindGameObjectWithTag("DioTrigger").SetActive(false);
                GameObject.FindGameObjectWithTag("WalkTalk").SetActive(false);
            }
        }

       /// text.GetComponent<UnityEngine.UI.Text>().text = marriageMeter.ToString();
    }
}
