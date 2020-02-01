using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInDialogue : MonoBehaviour
{
    public Dialogue[] dialogues;
    public TextAsset json;
    // Start is called before the first frame update
    void Start()
    {
        DialogueRead dr = JsonUtility.FromJson<DialogueRead>(json.text);
        dialogues = dr.dialogue;
        Debug.Log(dialogues.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


