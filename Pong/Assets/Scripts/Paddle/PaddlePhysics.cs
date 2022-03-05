using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePhysics : MonoBehaviour
{
    public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        var OtherRigidBody = collision.gameObject.GetComponent<Rigidbody2D>();
        if (OtherRigidBody == null) return;
        //Ballbody.velocity += OtherRigidBody.velocity * 10000000;
    }
}
