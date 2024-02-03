using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreStart : MonoBehaviour
{
    public GameObject emailOpened;
    // Start is called before the first frame update
    void Start()
    {
        emailOpened.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void close()
    {
        emailOpened.SetActive(false);
    }
    public void openAndClose()
    {
        if (emailOpened.activeInHierarchy == true)
        {
            emailOpened.SetActive(false);
        }
        else
        {
            emailOpened.SetActive(true);
        }

    }
}
