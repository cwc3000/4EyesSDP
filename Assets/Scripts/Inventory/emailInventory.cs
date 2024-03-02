using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emailInventory : MonoBehaviour
{
    public static emailInventory Instance;
    public List<emailItem> Emails = new List<emailItem>();
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    private void Awake()
    {
        Instance = this;
    }

    
    public void addEmail(emailItem email)
    {
        if (!email.isDefaultEmail)
        {
            Emails.Add(email);
            if (onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
        }

    }
}
