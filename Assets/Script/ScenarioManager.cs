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
    public GameObject KeyWords;

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
        TitleText.text = "Tutorial";
        DescText.text = "To start, say 'I'm ready to start my interview' to initiate the conversation. Please read through the keywords before starting. Press 'Start' when ready.";
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
    }

    // Function to start conversation
    public void StartConversation()
    {
        KeyWords.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
