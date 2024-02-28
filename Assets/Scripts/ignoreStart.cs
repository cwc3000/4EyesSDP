using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// or syntax ||

public class ignoreStart : MonoBehaviour
{
    public GameObject ignOpened;
    public GameObject otherOne;
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
        //if selected window is open and other is not, selected window closes
        if (ignOpened.activeInHierarchy == true && otherOne.activeInHierarchy == false)
        {
            ignOpened.SetActive(false);
            //if (gameObject.tag == "webLoc")
            //{
            //    ignOpened.transform.position = new Vector3(0, 519.6f, 0);
            //}
                

        }
        //and if selected window appears on top while both selected and other windows are active, then close selected window
        else if (ignOpened.transform.GetSiblingIndex() > otherOne.transform.GetSiblingIndex() && ignOpened.activeInHierarchy == true && otherOne.activeInHierarchy == true)
        {
            ignOpened.SetActive(false);
        }
        //otherwise, open the selected window and have it appear on top
        else
        {
            ignOpened.SetActive(true);
            //if (gameObject.tag == "emailLoc")
            //{
            //    ignOpened.transform.position = new Vector3(0, 32.513f,0);
            //}
            //else if (gameObject.tag == "webLoc")
            //{
            //    ignOpened.transform.position = new Vector3(0, 519.6f, 0);
            //}
            
            
            ignOpened.transform.SetAsLastSibling();
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
