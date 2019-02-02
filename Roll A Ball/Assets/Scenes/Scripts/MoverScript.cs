using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    Vector3 pointA = new Vector3(29, 1, 13);
    Vector3 pointB = new Vector3(19, 1, 13);


  
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));  
    }
}
