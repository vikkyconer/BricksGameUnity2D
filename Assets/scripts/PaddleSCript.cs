using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSCript : MonoBehaviour
{


    public Rigidbody2D rb2D;
    public float speed;
    public float Max_X;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        float x = Input.GetAxis("Horizontal");

        Touch touch = Input.GetTouch(0);

        var touchPosition = touch.position.x;

        if (touchPosition == Screen.width / 2) {
            Stop();
        }
        if (touchPosition < Screen.width/2) {
            MoveLeft();
        }
        if (touchPosition > Screen.width / 2) {
            MoveRight();
        }

        Vector3 position = transform.position;
        touchPosition = Mathf.Clamp(touchPosition, -Max_X, Max_X);
        transform.position = position;

        
    }


    void MoveLeft() {
        rb2D.velocity = new Vector2(-speed, 0);
    }

    void MoveRight() {
        rb2D.velocity = new Vector2(speed, 0);

    }

    void Stop() {
        rb2D.velocity = Vector2.zero;
    }

}
