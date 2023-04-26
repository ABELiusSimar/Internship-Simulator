using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [Header("Gameobjects")]
    public GameObject Panel;
    public GameObject Title;
    public GameObject Desc;
    public GameObject Button;

    [Header("Animations")]
    public Animator MyDoor = null;
    private bool _OpenTrigger = false;

    [Header("Scenario")]
    public TextMeshProUGUI TitleText;
    public TextMeshProUGUI DescText;

    // Start is called before the first frame update
    void Start()
    {
        TitleText.text = "Title of the scenario goes here";
        DescText.text = "Description of the title goes here";
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Function to handle scenarios of the game
    public void SelectScenario()
    {
        /* To-Do
         * Select Scenario
         * Start the scenario
         * Add door opening animation (Done)
         */

        // Door animation
        if (_OpenTrigger == false)
        {
            MyDoor.Play("Door");
            Panel.SetActive(false);
            Title.SetActive(false);
            Desc.SetActive(false);
            Button.SetActive(false);
        }
    }
}
