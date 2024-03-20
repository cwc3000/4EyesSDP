using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonPress : MonoBehaviour
{
    public GameObject objOpened;
    private GameObject self;
    private int clickNum;
    public GameObject notif;
    public bool showNotif = false;
    GameObject homePage;
    GameObject NYWN;
    //public GameObject file;
    // Start is called before the first frame update
    void Start()
    {
        objOpened.SetActive(false);
        clickNum = 0;
        if (notif = null)
        {
            notif = GameObject.FindWithTag("empty");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (showNotif)
        {
            notif.SetActive(true);
        }
        else if (!showNotif)
        {
            notif.SetActive(false);
        }
        homePage = GameObject.FindGameObjectWithTag("home");
        NYWN = GameObject.FindGameObjectWithTag("newsletter");
    }

    public void showNotification()
    {
        showNotif = true;
    }
    public void closeNotification()
    {
        showNotif = false;
    }
    public void open ()
    {
        objOpened.SetActive(true);
        //showNotif = false;
        objOpened.transform.SetAsLastSibling();
    }
    public void close ()
    {
        objOpened.SetActive(false); 
    }
    public void openAndClose()
    {
        if (objOpened.activeInHierarchy == true)
        {
            objOpened.SetActive(false);
        }
        else
        {
            objOpened.SetActive(true);
            
            objOpened.transform.SetAsLastSibling();
        } 
        
    }
    public void browserHome()
    {
        //homePage = GameObject.FindGameObjectWithTag("home");
        //NYWN = GameObject.FindGameObjectWithTag("newsletter");
        objOpened.SetActive(true);
        NYWN.SetActive(false);
    }
    public void logIn()
    {
        SceneManager.LoadScene("Play");
    }

    public void logOut ()
    {
        SceneManager.LoadScene("End1");
    }
    public void replay()
    {
        SceneManager.LoadScene("Login");
    }
}
