using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgementSystem : MonoBehaviour
{
    [Header("Variables")]
    public GameObject JudgePanel1;
    public GameObject JudgePanel2;
    public GameObject JudgePanel3;
    public GameObject JudgePanel4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function to close all panels
    public void Close()
    {
        JudgePanel1.SetActive(false);
        JudgePanel2.SetActive(false);
        JudgePanel3.SetActive(false);
        JudgePanel4.SetActive(false);
    }

    // Function to Open the panel 
    public void Open1()
    {
        JudgePanel1.SetActive(true);
        JudgePanel2.SetActive(false);
        JudgePanel3.SetActive(false);
        JudgePanel4.SetActive(false);
    }

    // Function to Open the panel 
    public void Open2()
    {
        JudgePanel1.SetActive(false);
        JudgePanel2.SetActive(true);
        JudgePanel3.SetActive(false);
        JudgePanel4.SetActive(false);
    }

    // Function to Open the panel 
    public void Open3()
    {
        JudgePanel1.SetActive(false);
        JudgePanel2.SetActive(false);
        JudgePanel3.SetActive(true);
        JudgePanel4.SetActive(false);
    }

    // Function to Open the panel 
    public void Open4()
    {
        JudgePanel1.SetActive(false);
        JudgePanel2.SetActive(false);
        JudgePanel3.SetActive(false);
        JudgePanel4.SetActive(true);
    }
}
