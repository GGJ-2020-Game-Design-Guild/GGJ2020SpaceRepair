using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInDialogue : MonoBehaviour
{
    Dialogue[] dialogues;
    public TextAsset json;
    // Start is called before the first frame update
    void Start()
    {
        dialogues = JsonUtility.FromJson<Dialogue[]>(json.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
