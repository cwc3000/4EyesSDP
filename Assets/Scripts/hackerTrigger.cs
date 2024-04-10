using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class hackerTrigger : MonoBehaviour
{
    public GameObject warningMSG;
    // Start is called before the first frame update
    void Start()
    {
        warningMSG.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void triggerHacker()
    {
        hackerManager HackerManager = FindObjectOfType<hackerManager>();
        HackerManager.InvokeRepeating("startSpamMSG", 6, Random.Range(15, 45));
        HackerManager.InvokeRepeating("glitchStart", 0, Random.Range(15, 60));
    }
    
    public void triggerSpam()
    {
        hackerManager HackerManager = FindObjectOfType<hackerManager>();
        HackerManager.InvokeRepeating("startSpamMSG", 1, Random.Range(15, 45));
    }

    public void triggerGlitch()
    {
        hackerManager HackerManager = FindObjectOfType<hackerManager>();
        HackerManager.Invoke("glitchStart", 0);
        warningMSG.SetActive(true);
        
        
            


    }
}
