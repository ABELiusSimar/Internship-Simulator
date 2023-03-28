using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    [Header("Input Action")]
    public InputActionProperty PinchAnimationAction; // Use to grab an action value from the XRI
    public InputActionProperty GripAnimationAction; // Use to grab an action value from the XRI

    [Header("Animator")]
    public Animator HandAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = PinchAnimationAction.action.ReadValue<float>(); // Input of the trigger button
        HandAnimator.SetFloat("Trigger", triggerValue); // Using trigger value from XRI input action

        float gripValue = GripAnimationAction.action.ReadValue<float>(); // Input of the trigger button
        HandAnimator.SetFloat("Grip", gripValue); // Using trigger value from XRI input action
    }
}
