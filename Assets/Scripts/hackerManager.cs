using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hackerManager : MonoBehaviour
{
    public GameObject spamBox;
    public GameObject contentArea;
    public Sprite[] spamImages;

    GameObject newSpamBox = null;
    private int i = 0;
    private float spawnRate = 0.1f;

    private int spamNum; // = Random.Range(6, 10);
    private int spamRandomizer; // = Random.Range(0, 3);
    private int startX;
    private int startY;

    //x: 960, 260-1700, 
    //y: 540, 270-700,  Mathf.Pow(startX, 0.3f) - 5*startX

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startSpamMSG()
    {
        i = 0;
        
        startX = Random.Range(300, 1700);
        startY = Random.Range(250, 700);
        InvokeRepeating("spawnSpamMsgs", 0, spawnRate);
        spamNum = Random.Range(6, 10);
           
    }
    
    public void spawnSpamMsgs()
    {

        //for (var i = 0; i < 6; i++){
        spamRandomizer = Random.Range(0, 3);

        if (i == spamNum)
        {
            endSpamMsgs();
        }
        
            newSpamBox = Instantiate(spamBox, new Vector3(-i*50 + startX, -i*60 + startY, 0), Quaternion.identity, contentArea.transform);
            newSpamBox.transform.Find("spam_Image").GetComponent<Image>().sprite = spamImages[spamRandomizer];
        i++;
        //}
        //StopAllCoroutines();

    }

    public void endSpamMsgs()
    {
        CancelInvoke("spawnSpamMsgs");

    }
    public void lag()
    {
        Time.timeScale = 0.8f;
    }

    public void glitch()
    {

    }
}
