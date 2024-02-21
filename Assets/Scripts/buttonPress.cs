using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonPress : MonoBehaviour
{
    public GameObject objOpened;
    private float clickNum;
    public GameObject notif;
    //public GameObject file;
    // Start is called before the first frame update
    void Start()
    {
        objOpened.SetActive(false);
        clickNum = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (clickNum == 0)
        {
            notif.SetActive(true);
        }
        else if (clickNum >= 1)
        {
            notif.SetActive(false);
        }
    }
    public void open ()
    {
        objOpened.SetActive(true);
        clickNum = clickNum + 1;
    }
    public void close ()
    {
        objOpened.SetActive(false);
        //file.SetActive(false);   
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
        } 
        
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
