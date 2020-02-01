using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Dialogue
{
    public Dialogue() {

    }

    public string type;
    public string text;
    public string incorrectAnswerResponse;
    public string correctAnswerResponse;
    public float time;
    public int answer;
    //public string answerA, answerB, answerC, answerD;
    
    
}
