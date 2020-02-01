using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DioTimeline : MonoBehaviour
{
    private ReadInDialogue jsonScript;
    private MarriageMeter marriageMeter;
    public int globalDio = 0;

    public void ReadInReady()
    {
        jsonScript = FindObjectOfType<ReadInDialogue>();
        marriageMeter = FindObjectOfType<MarriageMeter>();
       // Debug.Log(jsonScript.dialogues.Length);
        Invoke("changeDio", jsonScript.dialogues[globalDio].time);
    }


    void changeDio()
    {
        if (marriageMeter.marriageMeter > 0)
        {
            if (globalDio + 1 < jsonScript.dialogues.Length)
            {
                globalDio = globalDio + 1;
                Invoke("changeDio", jsonScript.dialogues[globalDio].time);
                marriageMeter.marriageMeter = marriageMeter.marriageMeter - 1;
            }
            else
            {
                globalDio = 0;
                Invoke("changeDio", jsonScript.dialogues[globalDio].time);
                marriageMeter.marriageMeter = marriageMeter.marriageMeter - 1;
            }
        }
    }
}
