using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Current;
    public float limitX = 4.35f;
    public Animator animator;

    public float runningSpeed;
    public float xSpeed;
    private float _currentRunningSpeed;
    private float startTouch;
    private float swipeDelta;
    void Start()
    {
        Current = this;

        

    }

    void Update()
    {
        //float newX;
        //float touchXDelta = 0;
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        //{
        //    touchXDelta = Input.GetTouch(0).deltaPosition.x / Screen.width;
        //}

        //else if (Input.GetMouseButton(0))
        //{
        //    touchXDelta = Input.GetAxis("Mouse X");

        //}
        
        //newX = transform.position.x + xSpeed * touchXDelta * Time.deltaTime;
        //newX = Mathf.Clamp(newX, -limitX, limitX);
        
        if (LevelController.Current.gameActive==true)
        {
            animator.SetBool("Running", true);
            Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + runningSpeed * Time.deltaTime);
            transform.position = newPosition;
        }
        



    }
}
