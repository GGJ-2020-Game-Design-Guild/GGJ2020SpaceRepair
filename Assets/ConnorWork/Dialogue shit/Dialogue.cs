﻿using System.Collections;
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
    public int answer;
    public float time;
    //public string answerA, answerB, answerC, answerD;
    
    
}
