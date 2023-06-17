using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MicManager : MonoBehaviour
{
    [Header("Variables")]
    public Text CaptureStatus;

    // Start is called before the first frame update
    void Start()
    {
        CaptureStatus.text = "Mic: on";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function to set capture
    public void StartCapture()
    {
        CaptureStatus.text = "Mic: on";
    }

    // Function to set not capture
    public void StopCapture()
    {
        CaptureStatus.text = "Mic: off";
    }
}
