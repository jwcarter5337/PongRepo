using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRound : MonoBehaviour


{
    public bool isplayer1;
    public GameObject Paddle1Win;
    public GameObject Paddle2Win;
    public GameObject ScoreObjectOrSomething;
    private Score ScoreBoard;
    public GameObject Balls;

    // Start is called before the first frame update
    void Start()
    {
        ScoreBoard = ScoreObjectOrSomething.GetComponent<Score>();

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("i am a good dick");
        if (isplayer1)
        {
            ScoreBoard.Paddle2Score++;
            Balls.SendMessage("ResetRight");
        }
        else
        {
            ScoreBoard.Paddle1Score++;
            Balls.SendMessage("ResetLeft");
        }
    }
}


