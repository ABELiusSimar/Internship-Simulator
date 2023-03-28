using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{
    [Header("Gameobjects")]
    public GameObject Menu;

    [Header("Actions")]
    public InputActionProperty ShowButton;

    [Header("Transform")]
    public Transform PlayerHead;

    [Header("Variables")]
    public float SpawnDistanceMenu = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ShowButton.action.WasPressedThisFrame())
        {
            Menu.SetActive(!Menu.activeSelf);
            Menu.transform.position = PlayerHead.position + new Vector3(PlayerHead.forward.x, 0, PlayerHead.forward.z).normalized * SpawnDistanceMenu;
        }

        Menu.transform.LookAt(new Vector3(PlayerHead.position.x, Menu.transform.position.y, PlayerHead.position.z));
        Menu.transform.forward *= -1;
    }
}
