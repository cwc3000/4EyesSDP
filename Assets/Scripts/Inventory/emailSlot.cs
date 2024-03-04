using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class emailSlot : MonoBehaviour
{
    public emailItem email;
    public Button emailButton;
    //public Image notif;
    
    //emailItem email;

    public void addEmail (emailItem newEmail)
    {
        email = newEmail;
        emailButton.enabled = true;
        //notif.enabled = true;
    }

    public void interactEmail()
    {
        if (email != null)
        {
            email.interact();
        }
    }
}
