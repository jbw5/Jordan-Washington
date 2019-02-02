using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover2Script : MonoBehaviour
{
    Vector3 pointC = new Vector3(30, 1, -5);
    Vector3 pointD = new Vector3(19, 1, -5);



    void Update()
    {
        transform.position = Vector3.Lerp(pointC, pointD, Mathf.PingPong(Time.time, 1));
    }
}
