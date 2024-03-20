using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// or syntax ||

public class ignoreStart : MonoBehaviour
{
    public GameObject ignOpened;
    //public GameObject otherOne;
    GameObject homePage;
    GameObject NYWN;
    GameObject objs;
    //GameObject selfTab;
    // Start is called before the first frame update
    void Start()
    {
        ignOpened.SetActive(true);
        homePage = GameObject.FindGameObjectWithTag("home");
        NYWN = GameObject.FindGameObjectWithTag("newsletter");
        objs = GameObject.FindGameObjectWithTag("objs");
        //selfTab = GameObject.transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void close()
    {
        ignOpened.SetActive(false);
    }
    public void closeSelfandPage()
    {
        this.transform.parent.gameObject.SetActive(false);
        ignOpened.SetActive(false);
    }
    
    //toggling system for bottom bar icons
    public void openAndClose()
    {
        //if selected window is closed, open it and bring to front
        if (ignOpened.activeInHierarchy == false)
        {
            ignOpened.SetActive(true);
            ignOpened.transform.SetAsLastSibling();

        }
        //if selected window is the last sibling, close it and bring it to the back
        else if (ignOpened.transform.GetSiblingIndex() == objs.transform.childCount - 1)
        {
            ignOpened.SetActive(false);
            ignOpened.transform.SetAsFirstSibling();
        }
        //otherwise, when toggling, bring it to the front
        else
        {
            ignOpened.transform.SetAsLastSibling();
        }

    }
    public void browserHome()
    {
        homePage.SetActive(true);
        //GameObject homeTab = GameObject.FindGameObjectWithTag("homeWebTab");
        //homeTab.SetActive(true);
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
