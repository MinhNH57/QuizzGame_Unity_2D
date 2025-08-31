using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quizz : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI m_TextMeshProUGUI;
    [SerializeField]
    public Question _questionSynterm;
    [SerializeField] public GameObject[] buttonAnswer;

    void Start()
    {
        m_TextMeshProUGUI.text = _questionSynterm.GetContent();

        for(int i = 0; i < buttonAnswer.Length; i++)
        {
            TextMeshProUGUI buttonText = buttonAnswer[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = _questionSynterm.GetAnswer(i);
        }
    }
}
