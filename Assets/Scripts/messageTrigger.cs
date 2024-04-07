using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messageTrigger : MonoBehaviour
{
    public MessageHolder message;
    public GameObject choicesObj;
    public GameObject messageNotif;
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
        }
    }

    public void activateMsgNotif()
    {
        messageNotif.SetActive(true);
    }

    public void triggerMessage()
    {
        messageNotif.SetActive(false);
        FindObjectOfType<messageManager>().StartMessage(message);
           

    }

}
