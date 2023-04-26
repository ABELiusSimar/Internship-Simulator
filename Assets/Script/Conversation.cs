using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Conversation : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI AnswerText;
    public TextMeshProUGUI QuestionText;
    public TextMeshProUGUI TimerText;

    [Header("Timer")]
    private float _CurrTime = 0f;
    private float _StartTime = 300f;

    [Header("Scenario")]
    public ScenarioManager Scenario;

    [Header("Questions")]
    public Button OptionButton1;
    public Button OptionButton2;
    public Button OptionButton3;
    public Button OptionButton4;

    private string _CurrentAnswer;
    private bool _Answered = false;
    private int _QuestionIndex = 0;

    // List of answers in string
    private string[] questions = new string[]
    {
        /*"What is the main programming language used in Unity?",
        "Where is PIT located?",
        "What is the biggest city in North Brabant",*/
        "What is 2+2?"
    };

    // List of answers in string
    private string[][] options = new string[][]
    {
        /*new string[] { "A) Java", "B) C#" },
        new string[] { "A) Tilburg", "B) Rotterdam" },
        new string[] { "A) Den Bosch", "B) Eindhoven" },*/
        new string[] { "A) Obvously it's 5", "B) The answer is 4", "C) The answer is 5", "D) Obviously it's 4" }
    };

    // List of correct answers
    private string[] answers = new string[]
    {
        /*"B",
        "A",
        "A",*/
        "B"
    };

    private void Start()
    {
        _CurrTime = _StartTime;
        NextQuestion();
    }

    private void Update()
    {
        if (Scenario.StartGame == 1)
        {
            // Game ends when timer is 0
            if (_CurrTime <= 0f)
            {
                // Wait until game has ended
            }
            else
            {
                _CurrTime -= 1 * Time.deltaTime; // Create a countdown that decreases per second
                TimerText.text = _CurrTime.ToString("0"); // Display only whole number
            }
        }
        else
        {
            // Wait
        }
    }

    void NextQuestion()
    {
        // Display the question and options
        QuestionText.text = questions[_QuestionIndex];
        OptionButton1.GetComponentInChildren<Text>().text = options[_QuestionIndex][0];
        OptionButton2.GetComponentInChildren<Text>().text = options[_QuestionIndex][1];
        OptionButton3.GetComponentInChildren<Text>().text = options[_QuestionIndex][2];
        OptionButton4.GetComponentInChildren<Text>().text = options[_QuestionIndex][3];

        // Set the current answer
        _CurrentAnswer = answers[_QuestionIndex];

        // Reset feedback text and answered flag
        AnswerText.text = "";
        _Answered = false;
    }

    public void CheckAnswer(string answer)
    {
        if (!_Answered)
        {
            if (answer == _CurrentAnswer)
            {
                AnswerText.text = "Correct!";
                // If the answer is correct go to the next question
                _QuestionIndex += 1;
                // Judge the answers
            }
            else
            {
                AnswerText.text = "Incorrect. The correct answer is " + _CurrentAnswer + ".";
                // Judge the answers
            }

            // Set answered flag to prevent further answering
            _Answered = true;
        }
    }

    public void NextButtonClicked()
    {
        // Go to the next question
        if (_QuestionIndex < questions.Length)
        {
            NextQuestion();
        }
        else
        {
            // End the game, stop the timer
            TimerText.text = "";
            QuestionText.text = "Conversation Completed";
            AnswerText.text = "";
            _CurrTime = 0f;
        }
    }
}
