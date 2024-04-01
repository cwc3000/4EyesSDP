using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messageTrigger : MonoBehaviour
{
    public MessageHolder message;
    public GameObject choicesObj;
    public GameObject messageNotif;
    //public Button thisButton;
    public bool isRiley;
    //public messageManager mM;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (FindObjectOfType<messageManager>().finishedMessage == true)
        {
            choicesObj.SetActive(true);
            //thisButton.interactable = false;
            //Destroy(this);
        }
    }

    public void activateMsgNotif()
    {
        messageNotif.SetActive(true);
        //thisButton.interactable = true;
    }

    public void triggerMessage()
    {
        FindObjectOfType<messageManager>().StartMessage(message);
        messageNotif.SetActive(false);
        choicesObj.SetActive(false);
        
           

    }

}
