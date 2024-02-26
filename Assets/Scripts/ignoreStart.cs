using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreStart : MonoBehaviour
{
    public GameObject ignOpened;
    GameObject homePage;
    GameObject NYWN;
    // Start is called before the first frame update
    void Start()
    {
        ignOpened.SetActive(true);
        homePage = GameObject.FindGameObjectWithTag("home");
        NYWN = GameObject.FindGameObjectWithTag("newsletter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void close()
    {
        ignOpened.SetActive(false);
    }
    public void openAndClose()
    {
        if (ignOpened.activeInHierarchy == true)
        {
            ignOpened.SetActive(false);
        }
        else
        {
            ignOpened.SetActive(true);
        }

    }
    public void browserHome()
    {
        homePage.SetActive(true);
        NYWN.SetActive(false);
    }
    public void goNewsletter()
    {
        //homePage = GameObject.FindGameObjectWithTag("home");
        //NYWN = GameObject.FindGameObjectWithTag("newsletter");
        NYWN.SetActive(true);
        homePage.SetActive(false);
        
    }
}
