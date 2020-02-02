using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPopUp : MonoBehaviour
{
    public GameObject playerCanvas;
    public bool isItem = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.parent)
        {
            if (collision.gameObject.transform.parent.gameObject.tag == "WalkTalk")
            {
                isItem = true;
            }
            else
            {
                isItem = false;
            }
        }
        else
        {
            isItem = false;
        }

        if (collision.gameObject.tag == "DioTrigger" || collision.gameObject.tag == "WalkTalk")
        {
            playerCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DioTrigger" || collision.gameObject.tag == "WalkTalk")
        {
            playerCanvas.SetActive(false);
        }
    }
}
