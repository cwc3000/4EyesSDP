using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class dropDownWebpage : MonoBehaviour
{
    public GameObject newsLetter;
    public GameObject homePage;
    public GameObject socMed;
    public TMP_Dropdown webpages;
    public GameObject webBrowser;
    public GameObject homeTab;
    public GameObject NYWNTab;
    public GameObject socMedTab;
    
    List<string> newsOption = new List<string> { "<b>New York Weekly Newsletter</b>     www.nycnewsupdates.com" };
    List<string> socMedOption = new List<string> { "<b>YourFace</b>     www.yourFace.com" };

    //Dropdown.OptionData newsOption;

    void Start()
    {
        //homeTab = GameObject.FindGameObjectWithTag("homeWebTab");
        //NYWNTab = GameObject.FindGameObjectWithTag("NYWNWebTab");
        //socMedTab = GameObject.FindGameObjectWithTag("socMedTab");
        //NYWNTab.SetActive(false);
        //socMedTab.SetActive(false);
    }

    public void changeWebpages(int value)
    {
        if(value == 0) //homepage
        {
            homePage.SetActive(true);
            homePage.transform.SetAsLastSibling();
            homeTab.SetActive(true);
            newsLetter.SetActive(false);
            socMed.SetActive(false);
        }

        if(value == 1) //newsletter page
        {
            if (webpages.options[1].text == "<b>New York Weekly Newsletter</b>     www.nycnewsupdates.com")
            {
                showNYWNPage();
            }
            else if (webpages.options[1].text == "<b>YourFace</b>     www.yourFace.com")
            {
                showSocMedPage();
            }

        }
        if (value == 2) //yourface page
        {
            if (webpages.options[2].text == "<b>New York Weekly Newsletter</b>     www.nycnewsupdates.com")
            {
                showNYWNPage();
            }
            else if (webpages.options[2].text == "<b>YourFace</b>     www.yourFace.com")
            {
                showSocMedPage();
            }
        }
        //case 0: homePage.SetActive(true); newsLetter.SetActive(false); break;
        //case 1: newsLetter.SetActive(true); homePage.SetActive(false); break;
    }

    public void showNYWNPage()
    {
        newsLetter.SetActive(true);
        newsLetter.transform.SetAsLastSibling();
        //NYWNTab.SetActive(true);
        homePage.SetActive(false);
        socMed.SetActive(false);
    }

    public void showSocMedPage()
    {
        socMed.SetActive(true);
        socMed.transform.SetAsLastSibling();
        //socMedTab.SetActive(true);
        newsLetter.SetActive(false);
        homePage.SetActive(false);
    }

    public void goHomePage()
    {
        homePage.SetActive(true);
        homeTab.SetActive(true);
        newsLetter.SetActive(false);
        webpages.value = 0;
    }

    public void activateNewsPage()
    {
        webBrowser.SetActive(true);
        webBrowser.transform.SetAsLastSibling();
        webpages.AddOptions(newsOption);
            //newsOption = new Dropdown.OptionData();
            //newsOption.text = "News";
            //newsLetter.SetActive(true);
        webpages.value = webpages.options.FindIndex(option => option.text == "<b>New York Weekly Newsletter</b>     www.nycnewsupdates.com");
        
    }
    public void activateSocMed()
    {
        webBrowser.SetActive(true);
        webBrowser.transform.SetAsLastSibling();
        webpages.AddOptions(socMedOption);
        webpages.value = webpages.options.FindIndex(option => option.text == "<b>YourFace</b>     www.yourFace.com");
    }
}
