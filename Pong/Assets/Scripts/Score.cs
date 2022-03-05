using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int Paddle1Score;
    public int Paddle2Score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var textUpdate = GetComponent<Text>();
        textUpdate.text = $"P1 {Paddle1Score}    P2 {Paddle2Score}";
        
    }

}
