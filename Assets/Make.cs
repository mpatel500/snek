using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Make : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public float speed = 1.5f;
    public int turnSpeed = 50;

    void Update()
    {
        /* if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("up arrow was pressed");
            transform.position += Vector3.up * speed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("down arrow was pressed");
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("left arrow was pressed");
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("right arrow was pressed");
            transform.position += Vector3.right * speed * Time.deltaTime;
        } */

        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();

        // float moveHorizontal = Input.GetAxis("Horizontal");
        // float moveVertical = Input.GetAxis("Vertical");
        // Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        // Debug.Log(movement);
        rigidBody.velocity = transform.up * speed * Time.deltaTime;

        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(new Vector3(0, 0, -turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal")));
        }
    }
}
