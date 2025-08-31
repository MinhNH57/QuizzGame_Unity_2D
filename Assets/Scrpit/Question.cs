using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (fileName ="Question" , menuName ="Question" , order =0)]
public class Question : ScriptableObject
{
    [TextArea(2,5)]
    [SerializeField]string question = "What are you learning now?";
    [SerializeField] string[] Answer = new string[4];
    [SerializeField] int correctAnswer;

    public string GetContent()
    {
        return question;
    }

    public string GetAnswer(int index)
    {
        return Answer[index];
    }

    public int GetCorrectAnswer()
    {
        return correctAnswer;
    }
}
