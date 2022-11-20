using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float rotateSpeed;

    
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
