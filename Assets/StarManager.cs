using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarManager : MonoBehaviour
{
    public GameObject[] stars;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Count.number <= 3 && Count.number != 0)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
        }
        else if(Count.number > 3 && Count.number <= 6)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(false);
        }
        else
        {
            stars[0].SetActive(true);
            stars[1].SetActive(false);
            stars[2].SetActive(false);
        }
    }
}
