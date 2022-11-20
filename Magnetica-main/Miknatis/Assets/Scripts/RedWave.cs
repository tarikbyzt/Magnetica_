using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RedWave : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private GameObject player;
    private Vector3 playerVect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerVect = new Vector3(_player.position.x, _player.position.y, _player.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("Knife"))
        //{
        //    other.transform.parent = player.transform;
        //    other.transform.LookAt(_player);
        //    Debug.Log("Knife");
        //    other.transform.DORotate(new Vector3(-90, other.transform.rotation.x, -90), 0.1f);
        //    other.transform.DOLocalMove(playerVect, 1);
        //    Destroy(other);
        //}
        //if (other.gameObject.CompareTag("Red"))
        //{
        //    other.GetComponent<Rigidbody>().useGravity = true;
        //    other.GetComponent<Rigidbody>().velocity = new Vector3(2,0,0);
        //    //if (other.transform.localPosition.x < -10)
        //    //{
        //    //    other.GetComponent<Rigidbody>().velocity = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        //    //    //other.transform.DORotate(new Vector3(-1, other.transform.rotation.y, transform.rotation.y), 0.3f);
        //    //    //other.transform.DOLocalMove(new Vector3(-23, other.transform.localPosition.y, other.transform.localPosition.z+5), 0.2f);
        //    //}
        //    //if (other.transform.localPosition.x > 20)
        //    //{
        //    //    other.GetComponent<Rigidbody>().velocity = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        //    //    //other.transform.DOLocalMove(new Vector3(33, 1.48f, 13), 0.1f);
        //    //}
        //}
        //if (other.gameObject.CompareTag("Blue"))
        //{
        //    other.transform.parent = player.transform;
        //    Debug.Log("Blue");
        //    other.transform.DOLocalMove(playerVect, 0.5f);
        //    Destroy(other);
        //    //other.transform.position = Vector3.Lerp(other.transform.position, _player.position, 2);
        //}
        


    }
}
