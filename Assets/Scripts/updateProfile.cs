using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateProfile : MonoBehaviour
{

    public GameObject[] PfpAreas;
    public Sprite[] pfpSprites;

    // PfpAreas: 0 is Aunt, 1 is friend, 2 is hacker, 3 is stonewall

    // Start is called before the first frame update
    void Start()
    {
        PfpAreas[0].GetComponent<Image>().sprite = pfpSprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateAuntPFP()
    {
        PfpAreas[0].GetComponent<Image>().sprite = pfpSprites[1];
    }

}
