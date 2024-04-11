using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateMessage : MonoBehaviour
{
    public GameObject[] msgOpened;
    public int msgNum = 1;
    public GameObject[] preMadeMsgs;
    // Start is called before the first frame update
    void Start()
    {
        msgOpened[msgNum].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void activateMSGSlot()
    {
        //open and activate message system, done a bit differently because of vertical layout group
        // 0 is parent slot, subsequent ones are different message triggers
        msgOpened[0].SetActive(true);
        msgOpened[0].transform.SetAsFirstSibling();
        activateMSG();        
    }

    public void activateMSG()
    {
        msgOpened[msgNum].SetActive(true);
        msgOpened[msgNum].transform.SetAsLastSibling();
        msgOpened[msgNum+1].SetActive(false);
        //msgOpened[msgNum].SetActive(true);
    }

    public void openPreMadeMsg()
    {
        // element 0 of msgOpened is used as the content area gameobject
        msgOpened[0].SetActive(true);
        msgOpened[0].transform.SetAsLastSibling();
        foreach (GameObject preMadeMsg in preMadeMsgs)
            preMadeMsg.GetComponentInChildren<Animator>().SetBool("isOpen", true);
    }

}
