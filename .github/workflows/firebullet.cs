using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class firebullet : MonoBehaviour
{
    public GameObject Bullet;
    public Transform spawnPoint;
    public float firespeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(fireBullet);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void fireBullet(ActivateEventArgs arg)
    {
        GameObject spawnbullet = Instantiate(Bullet);
        spawnbullet.transform.position = spawnPoint.position;
        spawnbullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * firespeed;
        Destroy(spawnbullet, 5);
    }
}
