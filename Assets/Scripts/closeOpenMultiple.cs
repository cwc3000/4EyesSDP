using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeOpenMultiple : MonoBehaviour
{
    public GameObject[] closedOpened;
    //public bool isOpenAlr = false;
    public bool bringToFront = false;
    // Start is called before the first frame update
    void Start()
    {

        //if (isOpenAlr)
        //{
        //    closedOpened[0].SetActive(true);
        //    closedOpened[1].SetActive(true);
        //}
        //else
        //{
        //    closedOpened[0].SetActive(false);
        //    closedOpened[1].SetActive(false);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void closeAll()
    {
        closedOpened[0].SetActive(false);
        closedOpened[1].SetActive(false);
    }
    public void OpenAll()
    {

        closedOpened[0].SetActive(true);
        closedOpened[1].SetActive(true);
        if (bringToFront)
        {
            closedOpened[0].transform.SetAsLastSibling();
        }

    }
}
