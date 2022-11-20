using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushScript : MonoBehaviour
{
    // Start is called before the first frame update

    Animator animator;
    Rigidbody rb;
    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("yatis", true);
        rb = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x < 0)
        {
            
            rb.isKinematic = false;
            rb.useGravity = true;
            rb.velocity = new Vector3(-25, 0, 30);
        }
        if (transform.position.x > 0)
        {
            
            rb.isKinematic = false;
            rb.useGravity = true;
            rb.velocity = new Vector3(25, 0, 30);
        }
    }

    
}
