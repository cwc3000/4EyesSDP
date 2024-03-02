using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emailUI : MonoBehaviour
{
    emailInventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = emailInventory.Instance;
        inventory.onItemChangedCallback += UpdateUI;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI()
    {

    }
}
