using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class hackerTrigger : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void triggerHacker()
    {
        hackerManager HackerManager = FindObjectOfType<hackerManager>();
        HackerManager.InvokeRepeating("startSpamMSG", 0, Random.Range(15, 60));
        //FindObjectOfType<hackerManager>().startSpamMSG();
    }
}
