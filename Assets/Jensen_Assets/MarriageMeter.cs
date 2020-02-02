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
        LevelGlobal.LevelText = "Hi honey! SURPRISE!!!!\n\nYour spouse surprised you by waiting for you at the concert! How nice!";
    }

    // Update is called once per frame
    void Update()
    {
        if (marriageMeter > 100)
        {
            marriageMeter = 100;
        }
        if (marriageMeter < 50) {
            LevelGlobal.LevelText = "This is unbelievable, I can't believe you care more about this concert than me.\n\nYour spouse is fairly upset, you'll hear about this later";
        }
        if (marriageMeter <= 0)
        {
            if (GameObject.FindGameObjectWithTag("DioTrigger") || GameObject.FindGameObjectWithTag("WalkTalk"))
            {
                LevelGlobal.LevelText = "I CANNOT BELIEVE YOU!\nWE'RE DONE!\n\nYou were not able to repair your relationship";
                GameObject.FindGameObjectWithTag("DioTrigger").SetActive(false);
                GameObject.FindGameObjectWithTag("WalkTalk").SetActive(false);
            }
        }

       /// text.GetComponent<UnityEngine.UI.Text>().text = marriageMeter.ToString();
    }
}
