using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireOnValidate : MonoBehaviour
{
    [Header("Bullet Variables")]
    public GameObject Bullet;
    public Transform SpawnPoint;
    public float FireSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabAble = GetComponent<XRGrabInteractable>();
        grabAble.activated.AddListener(FireBullet);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireBullet(ActivateEventArgs args)
    {
        GameObject spawnedBullet = Instantiate(Bullet);
        spawnedBullet.transform.position = SpawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = SpawnPoint.forward * FireSpeed;
        Destroy(spawnedBullet, 5f);
    }
}
