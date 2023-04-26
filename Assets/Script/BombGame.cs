using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BombGame : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI AnswerText;
    public TextMeshProUGUI QuestionText;
    public TextMeshProUGUI TimerText;

    [Header("Timer")]
    private float _CurrTime = 0f;
    private float _StartTime = 30f;

    [Header("Questions"), SerializeField]
    private string _Question;
    public string[] Answers = new string[] { };
    public int Correct = 1;
    public Button optionButton1;
    public Button optionButton2;

    // Start is called before the first frame update
    void Start()
    {
        QuestionText.text = _Question;
        optionButton1.GetComponentInChildren<Text>().text = Answers[0];
        optionButton2.GetComponentInChildren<Text>().text = Answers[1];
        _CurrTime = _StartTime;
    }

    // Update is called once per frame
    void Update()
    {
        // Bomb goes off if timer reaches 0
        if (_CurrTime <= 0f)
        {
            TimerText.text = "Boom";
            AnswerText.text = "";
            QuestionText.text = "";
        }
        else
        {
            _CurrTime -= 1 * Time.deltaTime; // Create a countdown that decreases per second
            TimerText.text = _CurrTime.ToString("0"); // Display only whole number
        }
    }

    // Function to check answer
    public void CheckAnswer(int answer)
    {
        if (answer == Correct)
        {
            AnswerText.text = "Correct";
        }
        else
        {
            AnswerText.text = "Incorrect";
        }
    }
}
