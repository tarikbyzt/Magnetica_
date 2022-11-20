using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    GameObject stickman,magnet;
    Animator playerAnimator;
    // Start is called before the first frame update
    private void Awake()
    {
        magnet= GameObject.FindGameObjectWithTag("Magnet");
        stickman = GameObject.FindGameObjectWithTag("Stickman");
        playerAnimator = stickman.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            other.transform.parent = gameObject.transform;
            other.GetComponent<ObsMove>().enabled = false;
            other.GetComponent<Animator>().enabled = true ;
            LevelController.Current.ChangeScore(10);
            Destroy(other.gameObject, 1f);
            

        }
        if (other.gameObject.tag=="Finish")
        {
            magnet.SetActive(false);
            playerAnimator.SetBool("Running", false);
            playerAnimator.SetBool("Dance", true);
            LevelController.Current.FinishMenu();
        }
        if (other.gameObject.tag=="RedHeal"|| other.gameObject.tag == "BlueHeal")
        {
            other.GetComponent<Animator>().SetTrigger("kuculme");
            Health.Current.Heal(20);
            Destroy(other.gameObject, 1f);
        }
        if (other.gameObject.tag == "Red" || other.gameObject.tag == "Blue")
        {
            playerAnimator.SetTrigger("Hit");
            Debug.Log("ölümcül olmayan hasar");
            Health.Current.TakeDamage(10);
            Destroy(other.gameObject, 1f);
            StartCoroutine(Slowlyspeed());
        }
        
    }

    IEnumerator Slowlyspeed()
    {
        PlayerController.Current.runningSpeed = 10;
        yield return new WaitForSeconds(0.6f);
        PlayerController.Current.runningSpeed = 20;
    }
}
