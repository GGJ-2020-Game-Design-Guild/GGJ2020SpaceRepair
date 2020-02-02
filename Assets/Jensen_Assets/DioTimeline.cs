using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DioTimeline : MonoBehaviour
{
    private ReadInDialogue jsonScript;
    private MarriageMeter marriageMeter;
    public int globalDio = 0;
    public AudioClip newM;

    public int spouceNum;

    public void ReadInReady()
    {
        jsonScript = FindObjectOfType<ReadInDialogue>();
        marriageMeter = FindObjectOfType<MarriageMeter>();

        spouceNum = Random.Range(1, 4);
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
                marriageMeter.marriageMeter = marriageMeter.marriageMeter - 5;
                AudioSource.PlayClipAtPoint(newM, FindObjectOfType<Camera>().transform.position, 2.0f);
            }
            else
            {
                globalDio = 0;
                Invoke("changeDio", jsonScript.dialogues[globalDio].time);
                marriageMeter.marriageMeter = marriageMeter.marriageMeter - 5;
            }
        }
    }
}
