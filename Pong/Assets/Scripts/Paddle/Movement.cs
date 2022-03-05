using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [InspectorName("UpButton")] public KeyCode Up;

    [InspectorName("DownButton")] public KeyCode Down;

    private Vector3 StartPosition;
    private Rigidbody2D Paddle;
    public int Speed;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        Debug.Log("working");
        Paddle=GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Up))
        {
            Paddle.velocity = Vector2.up * Speed;
        }



        if (Input.GetKey(Down))
        {
            Paddle.velocity = Vector2.down * Speed;
        }


        //if(Input.GetKey (Up) && (gameObject.transform.position.y< 3.234843))
        //{

        //    this.gameObject.transform.position += Vector3.up * 10 * Time.deltaTime;

        //}
        //else if (Input.GetKey(Down) && (gameObject.transform.position.y > -3.283334))
        //{
        //    this.gameObject.transform.position -= Vector3.up * 10 * Time.deltaTime;

        //}
    }
}
