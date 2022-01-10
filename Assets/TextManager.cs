using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    // Start is called before the first frame update
    Text tossCount;
    static int totalcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        tossCount = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        totalcount = Count.number;
        tossCount.text = "Toss Count: " + totalcount;
    }
}
