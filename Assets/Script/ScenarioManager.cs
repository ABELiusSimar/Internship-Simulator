using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScenarioManager : MonoBehaviour
{   
    [Header("Scenario")]
    public TextMeshProUGUI TitleText;
    public TextMeshProUGUI DescText;

    [Header("Start Game")]
    public int StartGame;
    public GameObject ConversationGame;

    // Start is called before the first frame update
    void Start()
    {
        StartGame = 0;
        if (StartGame == 0) // Game no start
        {
            // Set game to false
            ConversationGame.SetActive(false);
        }

        // Set Scenario
        TitleText.text = "Sprint 2 Demo";
        DescText.text = "In this scenario, select an appropriate response for the question at hand";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function to start game
    public void StartTheGame()
    {
        StartGame = 1;
        ConversationGame.SetActive(true);
        this.gameObject.SetActive(false);
        // Something to check which scenario was chosen
    }
}