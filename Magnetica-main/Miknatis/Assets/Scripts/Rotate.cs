using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotate : MonoBehaviour
{
    public float rotatespeed = 200f;
    private float startingPosition;
    

    void Update()
    {
        if (LevelController.Current.gameActive)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                switch (touch.phase)
                {
                    case TouchPhase.Stationary:
                        startingPosition = touch.position.x;
                        break;
                    case TouchPhase.Began:
                        startingPosition = touch.position.x;
                        break;
                    case TouchPhase.Moved:
                        if (startingPosition > touch.position.x)
                        {
                            transform.Rotate(Vector3.down, -rotatespeed * Time.deltaTime);
                        }
                        else if (startingPosition < touch.position.x)
                        {
                            transform.Rotate(Vector3.down, rotatespeed * Time.deltaTime);
                        }
                        break;
                    case TouchPhase.Ended:
                        Debug.Log("Touch Phase Ended.");
                        break;
                }
            }
        }
        
    }
}

