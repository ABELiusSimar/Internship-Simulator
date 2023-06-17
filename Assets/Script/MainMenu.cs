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

    [Header("Audio")]
    public AudioSource DoorOpenSound = null;

    [Header("Scenario")]
    public TextMeshProUGUI TitleText;
    public TextMeshProUGUI DescText;

    // Start is called before the first frame update
    void Start()
    {
        TitleText.text = "New Job";
        DescText.text = "Arrived at a software company for your interview";
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Function to handle scenarios of the game
    public void SelectScenario()
    {
        // Door animation
        if (_OpenTrigger == false)
        {
            MyDoor.Play("Door");
            Panel.SetActive(false);
            Title.SetActive(false);
            Desc.SetActive(false);
            Button.SetActive(false);
            DoorOpenSound.Play();
        }
    }
}
