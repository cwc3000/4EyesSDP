using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messageTrigger : MonoBehaviour
{
    public MessageHolder message;
    public GameObject[] choicesObj;
    public GameObject messageAlert;
    public GameObject messageNotif;
    //public Button thisButton;
    //public bool isRiley;

    public bool fromStonewall = false;
    public bool fromDetectiveFriend = false;
    public bool fromHacker = false;
    
    public bool clicked = false;

    //public GameObject messageArea;
    //public messageManager mM;
    void Start()
    {
        choicesObj[0].SetActive(false);
        choicesObj[1].SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        if (FindObjectOfType<messageManager>().finishedMessage == true && clicked)
        {
            choicesObj[0].SetActive(true);
            Destroy(messageAlert);
        }
    }

    public void triggerMessage()
    {
        // 0 is stonewall, 1 is detective friend, 2 is hacker, 3 is auntie, 4 is father, 5 is nia

        if (fromStonewall)
        {
            FindObjectOfType<messageManager>().contentAreaInt = 0;
        }
        else if (fromDetectiveFriend)
        {
            FindObjectOfType<messageManager>().contentAreaInt = 1;
        }
        else if (fromHacker)
        {
            FindObjectOfType<messageManager>().contentAreaInt = 2;
        }

        FindObjectOfType<messageManager>().StartMessage(message);
        messageNotif.SetActive(false);
        messageAlert.GetComponent<Button>().interactable = false;
        messageAlert.GetComponentInChildren<Image>().enabled = false;
        clicked = true;
    }

}
