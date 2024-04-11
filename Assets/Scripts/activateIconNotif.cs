using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class activateIconNotif : MonoBehaviour
{
    public GameObject iconNotif;

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
        iconNotif.SetActive(true);
    }

    public void turnOffNotif()
    {
        iconNotif.SetActive(false);
    }

}
