using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("MakeSquare",0.0f,1f);
    }

    public GameObject square;
    public Text timeTxt;

    void MakeSquare()
    {
        Instantiate(square);
    }
    float time = 0f;
    void Update()
    {
        time += Time.deltaTime;
        timeTxt.text = time.ToString("N2");
    }
}