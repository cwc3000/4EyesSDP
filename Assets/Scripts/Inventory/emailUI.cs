using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class emailUI : MonoBehaviour
{
    emailInventory inventory;

    public Transform emailsParent;
    emailSlot[] slots;

    // Start is called before the first frame update
    void Start()
    {
        inventory = emailInventory.Instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = emailsParent.GetComponentsInChildren<emailSlot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if(i < inventory.Emails.Count)
            {
                slots[i].addEmail(inventory.Emails[i]);
            }
        }
    }
}
