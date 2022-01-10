using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public static int number = 0;
    Text TossCount;
    // Start is called before the first frame update
    void Start()
    {
        TossCount = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        TossCount.text = "Toss Count: " + number;
    }
}
