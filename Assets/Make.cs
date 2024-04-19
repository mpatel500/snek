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
    public float speed = 0.5f;

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

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        Debug.Log(movement);
        rigidBody.velocity = movement * speed;
    }
}
