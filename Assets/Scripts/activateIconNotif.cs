using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class activateIconNotif : MonoBehaviour
{
    public GameObject iconNotif;

    public AudioSource audioSource2;
    public AudioClip notifSound;

    // Start is called before the first frame update
    void Start()
    {
        iconNotif.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void turnOnNotif()
    {
        audioSource2.clip = notifSound;
        audioSource2.Play();
        iconNotif.SetActive(true);
        Destroy(this.gameObject);
    }

    public void turnOffNotif()
    {
        iconNotif.SetActive(false);
    }

}
