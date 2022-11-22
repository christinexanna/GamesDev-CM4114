using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // The pace at which the player moves
    public float moveSpeed = 3;
   
    // The pace at which the player moves to the right
    public float leftRightSpeed = 4;

    // Update is called once per frame
    void Update()
    {
        // Moves the player forward relative to the player speed
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        // move left with the A key or left arrow key
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            // Restrict player movements to be within boundary
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                // Moves the player to the left relative to the leftRight player speed
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }

        // move right with the A key or right arrow key
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                // Moves the player to the right relative to the leftRight player speed
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }
                
        }
    }
}
