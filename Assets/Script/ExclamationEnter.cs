using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExclamationEnter : MonoBehaviour
{
    [Header("Gameobjects")]
    public GameObject Excalamation;
    public GameObject MicPanel;
    public GameObject PushToTalkPanel;

    private void OnTriggerEnter(Collider other)
    {
        Excalamation.SetActive(false);
        MicPanel.SetActive(true);
        PushToTalkPanel.SetActive(true);
    }
}
