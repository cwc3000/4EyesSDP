using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class dropDownWebpage : MonoBehaviour
{
    public GameObject newsLetter;
    public GameObject homePage;
    public TMP_Dropdown webpages;
    public GameObject webBrowser;
    GameObject homeTab;
    GameObject NYWNTab;
    private int clickNum;
    List<string> newsOption = new List<string> { "<b>New York Weekly Newsletter</b>     www.nycnewsupdates.com" };
    

    //Dropdown.OptionData newsOption;

    void Start()
    {
        //clickNum = 0;
        homeTab = GameObject.FindGameObjectWithTag("homeWebTab");
        NYWNTab = GameObject.FindGameObjectWithTag("NYWNWebTab");
        NYWNTab.SetActive(false);
    }

    public void changeWebpages(int value)
    {
        if(value == 0)
        {
            homePage.SetActive(true);
            homeTab.SetActive(true);
            newsLetter.SetActive(false);
        }

        if(value == 1)
        {
            newsLetter.SetActive(true);
            NYWNTab.SetActive(true);
            homePage.SetActive(false);
        }
        //case 0: homePage.SetActive(true); newsLetter.SetActive(false); break;
        //case 1: newsLetter.SetActive(true); homePage.SetActive(false); break;
    }

    public void goHomePage()
    {
        homePage.SetActive(true);
        homeTab.SetActive(true);
        newsLetter.SetActive(false);
        webpages.value = 0;
    }

    public void activateWebpage()
    {
        clickNum++;
        webBrowser.SetActive(true);
        webBrowser.transform.SetAsLastSibling();
        if (clickNum == 1)
        {
            webpages.AddOptions(newsOption);
            //newsOption = new Dropdown.OptionData();
            //newsOption.text = "News";
            //newsLetter.SetActive(true);
        }
        webpages.value = 1;
    }
}
