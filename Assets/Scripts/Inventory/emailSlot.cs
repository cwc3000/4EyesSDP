using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class emailSlot : MonoBehaviour
{
    public Button emailButton;
    //public GameObject notif;
    
    emailItem email;

    public void addEmail (emailItem newEmail)
    {
        email = newEmail;
        emailButton.enabled = true;
        //notif.SetActive(true);
    }

    public void interactEmail()
    {
        if (email != null)
        {
            email.interact();
        }
    }
}
