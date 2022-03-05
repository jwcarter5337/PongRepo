using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class BAUL : MonoBehaviour
{
    public GameObject Paddle1;
    public GameObject Paddle2;
    private Rigidbody2D Ballbody;
    public float BallFriction;
    private Vector3 StartPosition;
    public GameObject BallServe;
    

    // Start is called before the first frame update
    void Start()
    {
        Ballbody = GetComponent<Rigidbody2D>();
        Ballbody.velocity=new Vector2(10,0);
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Ballbody.IsTouching(Paddle1.GetComponent<Collider2D>()))
        {
            var OtherRigidBody = Paddle1.GetComponent<Rigidbody2D>();
            if (OtherRigidBody == null) return;
            Ballbody.velocity = Ballbody.velocity * (1.01f);
            Ballbody.velocity += OtherRigidBody.velocity * BallFriction;
            Debug.Log($"{Ballbody.velocity}BigBagOfDicks");
        }
    }

    void ResetLeft()
    {
        gameObject.transform.position = StartPosition;
        Ballbody.velocity = new Vector2(10, 0);
        var Score = BallServe.GetComponent<Score>();

    }

    void ResetRight()
    {
        gameObject.transform.position = StartPosition;
        Ballbody.velocity = new Vector2(-10, 0);
        var Score = BallServe.GetComponent<Score>();

    }
}
