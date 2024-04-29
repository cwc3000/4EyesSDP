using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Kino;

public class hackerManager : MonoBehaviour
{
    public GameObject spamBox;
    public GameObject contentArea;
    public Sprite[] spamImages;

    GameObject newSpamBox = null;
    private int i = 0;
    private float spawnRate = 0.1f;

    private int spamNum; // = Random.Range(6, 10);
    private int spamRandomizer; // = Random.Range(0, 4);
    private int startX;
    private int startY;

    public DigitalGlitch digitalGlitch;
    public AnalogGlitch analogGlitch;

    public bool startedHack = false;
    //public bool playedOnce = false;

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

        startX = Random.Range(-700, 700);
        startY = Random.Range(-100, 350);
        InvokeRepeating("spawnSpamMsgs", 0, spawnRate);
        spamNum = Random.Range(4, 8);
           
    }
    
    public void spawnSpamMsgs()
    {

        //for (var i = 0; i < 6; i++){
        spamRandomizer = Random.Range(0, 4);

        if (i == spamNum)
        {
            endSpamMsgs();
        }
        

        //newSpamBox = Instantiate(spamBox, new Vector3(-i*50 + startX, -i*60 + startY, 0), Quaternion.identity, contentArea.transform);
        newSpamBox = Instantiate(spamBox, contentArea.transform);
        newSpamBox.transform.localPosition = new Vector3(-i*50 + startX, -i*60 + startY, 0);

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

    public void glitchStart()
    {
        digitalGlitch.intensity = Random.Range(0.1f, 0.8f);
        analogGlitch.scanLineJitter = Random.Range(0.1f, 0.7f);
        analogGlitch.verticalJump = Random.Range(0.1f, 0.4f);
        analogGlitch.horizontalShake = Random.Range(0.1f, 0.5f);
        analogGlitch.colorDrift = Random.Range(0.1f, 0.8f);
        StartCoroutine(glitchTime());
    }

    public void glitchEnd()
    {
        digitalGlitch.intensity = 0;
        analogGlitch.scanLineJitter = 0;
        analogGlitch.verticalJump = 0;
        analogGlitch.horizontalShake = 0;
        analogGlitch.colorDrift = 0;
        startedHack = true;
    }

    IEnumerator glitchTime()
    {
        yield return new WaitForSeconds(Random.Range(2, 5));
        glitchEnd();
    }
    public void finalVidGlitch()
    {
        digitalGlitch.intensity = 0;
        analogGlitch.scanLineJitter = 0.05f;
        analogGlitch.verticalJump = 0.02f;
        analogGlitch.horizontalShake = 0;
        analogGlitch.colorDrift = 0.02f;
    }
}
