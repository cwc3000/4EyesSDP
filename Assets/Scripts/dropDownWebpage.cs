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
    GameObject homeTab;
    GameObject NYWNTab;
    GameObject socMedTab;
    private int clickNum;
    private int pageNum;
    
    List<string> newsOption = new List<string> { "<b>New York Weekly Newsletter</b>     www.nycnewsupdates.com" };
    List<string> socMedOption = new List<string> { "<b>YourFace</b>     www.yourFace.com" };

    //Dropdown.OptionData newsOption;

    void Start()
    {
        //clickNum = 0;
        homeTab = GameObject.FindGameObjectWithTag("homeWebTab");
        NYWNTab = GameObject.FindGameObjectWithTag("NYWNWebTab");
        socMedTab = GameObject.FindGameObjectWithTag("socMedTab");
        NYWNTab.SetActive(false);
        socMedTab.SetActive(false);
        //pageNum = webpages.value;
    }

    public void changeWebpages(int value)
    {
        if(value == 0)
        {
            homePage.SetActive(true);
            homeTab.SetActive(true);
            newsLetter.SetActive(false);
            socMed.SetActive(false);
        }

        if(value == 1)
        {
            Debug.Log(value);
            newsLetter.SetActive(true);
            NYWNTab.SetActive(true);
            homePage.SetActive(false);
            socMed.SetActive(false);
        }
        if (value == 2)
        {
            socMed.SetActive(true);
            socMedTab.SetActive(true);
            newsLetter.SetActive(false);
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

    public void activateNewsPage()
    {
        clickNum = 1;
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
    public void activateSocMed()
    {
        clickNum = 2;
        webBrowser.SetActive(true);
        webBrowser.transform.SetAsLastSibling();
        if (clickNum == 2)
        {
            webpages.AddOptions(socMedOption);
        }
        webpages.value = 2;
    }
}
