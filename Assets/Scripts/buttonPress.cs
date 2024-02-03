using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonPress : MonoBehaviour
{
    public GameObject objOpened;
    //public GameObject file;
    // Start is called before the first frame update
    void Start()
    {
        objOpened.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void open ()
    {
        objOpened.SetActive(true);
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
