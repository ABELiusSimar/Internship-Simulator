using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActiveTeleportationRay : MonoBehaviour
{
    [Header("Game Objects")]
    public GameObject LeftTeleportation;
    public GameObject RightTeleportation;

    [Header("Action Variables")]
    public InputActionProperty LeftActivate;
    public InputActionProperty RightActivate;
    public InputActionProperty LeftCancel;
    public InputActionProperty RightCancel;

    [Header("Interactors")]
    public XRRayInteractor LeftRay;
    public XRRayInteractor RightRay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Boolean to check whether a ray is active or not
        bool isLeftRayHovering = LeftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNormal, out int leftNumber, out bool leftValid);
        bool isRightRayHovering = RightRay.TryGetHitInfo(out Vector3 rightPos, out Vector3 rightNormal, out int rightNumber, out bool rightValid);

        LeftTeleportation.SetActive(!isLeftRayHovering && LeftCancel.action.ReadValue<float>() == 0 && LeftActivate.action.ReadValue<float>() > 0.1f);
        RightTeleportation.SetActive(!isRightRayHovering && RightCancel.action.ReadValue<float>() == 0 && RightActivate.action.ReadValue<float>() > 0.1f);
    }
}
