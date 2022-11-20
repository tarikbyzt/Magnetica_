using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{
    
    public Transform playerTransform;
    public float moveSpeed = 17f;


    ObsMove obsMoveScript;
    PushScript pushScript;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        obsMoveScript = gameObject.GetComponent<ObsMove>();
        pushScript = gameObject.GetComponent<PushScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Red Wave")
        {
            
            if (gameObject.tag == "Blue"|| gameObject.tag == "BlueHeal"|| gameObject.tag == "Coin")
            {
                Debug.Log("Kırmızı dalga Mavi Çarptı");
                obsMoveScript.enabled = true;
            }
            if (gameObject.tag=="Red"|| gameObject.tag == "RedHeal")
            {
                Debug.Log("kırmızı dalga Kırmızı Çarptı");
                pushScript.enabled = true;
            }
        }
        if (other.gameObject.tag == "Blue Wave")
        {
            if (gameObject.tag == "Red"|| gameObject.tag == "RedHeal"|| gameObject.tag == "Coin")
            {
                Debug.Log("Kırmızı Çarptı");
                obsMoveScript.enabled = true;
            }
            if (gameObject.tag == "Blue"|| gameObject.tag == "BlueHeal")
            {
                Debug.Log("Mavi Çarptı");
                pushScript.enabled = true;
            }
        }
    }
}
