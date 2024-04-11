using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activateSocMed : MonoBehaviour
{
    public GameObject needOpened;
    public bool wasOpened = false;
    public GameObject auntUpdateObj;
    public GameObject auntMsgNotif;
    public Image auntPFP;
    public Sprite newAuntPFP;
    public GameObject iconNotif;

    hackerManager HackerManager;
    
    // Start is called before the first frame update
    void Start()
    {
        HackerManager = FindObjectOfType<hackerManager>();
        auntMsgNotif.SetActive(false);
        auntUpdateObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (HackerManager.startedHack && wasOpened)
        {
            
            auntUpdate();
            
        }
    }

    public void open()
    {
        needOpened.SetActive(true);
        needOpened.transform.SetAsLastSibling();
        wasOpened = true;
    }

    public void auntUpdate()
    {
        wasOpened = false;
        auntMsgNotif.SetActive(true);
        auntUpdateObj.SetActive(true);
        auntPFP.sprite = newAuntPFP;
        
        iconNotif.SetActive(true);
        //iconNotif.GetComponent<Animator>().SetBool("open", true);

    }
}
