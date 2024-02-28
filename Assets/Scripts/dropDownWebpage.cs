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

    private int clickNum;
    Dropdown.OptionData newsOption;
    void Start()
    {
        //clickNum = 0;
    }

    public void changeWebpages(int value)
    {
        if(value == 0)
        {
            homePage.SetActive(true); 
            newsLetter.SetActive(false);
        }

        if(value == 1)
        {
            newsLetter.SetActive(true); 
            homePage.SetActive(false);
        }
        //case 0: homePage.SetActive(true); newsLetter.SetActive(false); break;
        //case 1: newsLetter.SetActive(true); homePage.SetActive(false); break;
    }

    public void goHomePage()
    {
        homePage.SetActive(true);
        newsLetter.SetActive(false);
        webpages.value = 0;
    }

    public void activateWebpage()
    {
        //clickNum++;
        webBrowser.SetActive(true);
        webBrowser.transform.SetAsLastSibling();
        //if (clickNum >= 1)
        //{
            newsOption = new Dropdown.OptionData();
            newsOption.text = "News";
            newsLetter.SetActive(true);
        //}
    }
}
