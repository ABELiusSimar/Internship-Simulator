using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialManager : MonoBehaviour
{
    [Header("Gameobjects")]
    public GameObject TutorialPanel;
    public GameObject GrabPanel;
    public GameObject TeleportPanel;
    public GameObject MenuPanel;

    [Header("Tutorial Functions")]
    public TextMeshProUGUI Description;
    private int _Page;

    // Start is called before the first frame update
    void Start()
    {
        // Make sure page starts at 0
        _Page = 0;
        Description.text = "Welcome to Esteemed playthrough.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function to scroll through tutorial
    public void Tutorial()
    {
        _Page++;

        if (_Page == 1)
        {
            Description.text = "In this playthrough, you are an IT graduate preparing for an interview at a Software firm.";
        }
        else if (_Page == 2)
        {
            Description.text = "To the left there is a small tutorial on the mechanics of the game.";
        }
        else if (_Page == 3)
        {
            Description.text = "Proceed to the '!' when ready.";
        }
        else if (_Page == 4)
        {
            TutorialPanel.SetActive(false);
            GrabPanel.SetActive(true);
        }
        else if (_Page == 5)
        {
            GrabPanel.SetActive(false);
            TeleportPanel.SetActive(true);
        }
        else if (_Page == 6)
        {
            TeleportPanel.SetActive(false);
            MenuPanel.SetActive(true);
        }
        else if (_Page == 7)
        {
            MenuPanel.SetActive(false);
        }
    }

    /* To-Do List
     * Create the first tutorial for grab, teleport, and menu
     * Create the second tutorial for Push To Talk and AI Interaction
     */
}
