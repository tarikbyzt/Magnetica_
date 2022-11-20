using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class ObsMove : MonoBehaviour
{

    public Animator animator, playerAnimator;
    
    GameObject stickman;
    Coin coinScript;
    Rigidbody rb;
    private void Awake()
    {
        stickman = GameObject.FindGameObjectWithTag("Stickman");
        
        animator = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody>();
        coinScript = gameObject.GetComponent<Coin>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
        animator.SetTrigger("kuculme");


    }

    // Update is called once per frame
    void Update()
    {


        transform.position = Vector3.MoveTowards(transform.position, coinScript.playerTransform.position,
        coinScript.moveSpeed * Time.deltaTime);



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //if (gameObject.tag=="BlueKnife"|| gameObject.tag == "RedKnife")
            //{
            //    knifeTrigger = true;
            //    gameObject.transform.parent = stickman.transform;
            //    transform.localPosition = new Vector3(-1.886f, 2.084f, 0.057f);
            //    transform.Rotate(0, -12.881f, 35.013f);
            //    playerAnimator.SetBool("KnifeDeath",true);
            //    Debug.Log("ölümcül hasar");
            //    Health.Current.TakeDamage(100);

            //}
            //if (gameObject.tag=="Heal")
            //{
            //    Health.Current.Heal(20);
            //}
            
           


        }
    }
}
