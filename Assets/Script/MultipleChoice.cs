using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MultipleChoice : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI AnswerText;

    // Function that check the correct answer
    public void Correct()
    {
        AnswerText.text = "Correct";
    }

    // Function that check the Wrong answer
    public void Wrong()
    {
        AnswerText.text = "Wrong";
    }
}
