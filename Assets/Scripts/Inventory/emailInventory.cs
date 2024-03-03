using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emailInventory : MonoBehaviour
{
    public static emailInventory Instance;
    public List<emailItem> Emails = new List<emailItem>();
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public GameObject suspensionEmail;
    public GameObject NYBBEmail;
    public GameObject NYWNEmail;
    public GameObject PrivInvEmail;
    public GameObject RentEmail;
    public GameObject PrivInvEmailTwo;

    //private void Awake()
    //{
    //    Instance = this;
    //}

    private void Start()
    {
        RentEmail.SetActive(true);
        PrivInvEmail.SetActive(true);
        NYWNEmail.SetActive(true);
        NYBBEmail.SetActive(true);
        suspensionEmail.SetActive(true);
        PrivInvEmailTwo.SetActive(false);
    }


    //public void addEmail(emailItem email)
    //{
    //    if (!email.isDefaultEmail)
    //    {
    //        Emails.Add(email);
    //        if (onItemChangedCallback != null)
    //            onItemChangedCallback.Invoke();
    //    }

    //}
}
