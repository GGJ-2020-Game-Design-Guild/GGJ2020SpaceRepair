using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DioTimeline : MonoBehaviour
{
    private ReadInDialogue jsonScript;
    public int globalDio = 0;

    public void ReadInReady()
    {
        jsonScript = FindObjectOfType<ReadInDialogue>();
       // Debug.Log(jsonScript.dialogues.Length);
        Invoke("changeDio", jsonScript.dialogues[globalDio].time);
    }


    void changeDio()
    {
        if (globalDio + 1 < jsonScript.dialogues.Length)
        {
            globalDio = globalDio + 1;
            Invoke("changeDio", jsonScript.dialogues[globalDio].time);
        }
        else
        {
            globalDio = 0;
            Invoke("changeDio", jsonScript.dialogues[globalDio].time);
        }
    }
}
