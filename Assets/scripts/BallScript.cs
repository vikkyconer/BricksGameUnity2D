using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public Rigidbody2D rigidbody2D;
    public float ballForce;
    bool gameStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0  && gameStarted == false) {

            transform.SetParent(null);
            rigidbody2D.isKinematic = false;

            rigidbody2D.AddForce(new Vector2(ballForce, ballForce));

            gameStarted = true;
        }
        
    }

}
