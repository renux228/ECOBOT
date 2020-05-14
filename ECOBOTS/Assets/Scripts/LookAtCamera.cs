using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private Transform Cam;
    private Transform _body;
 
    void Start()
    {
        _body = gameObject.GetComponent<Transform>();
        Cam = GameObject.FindGameObjectWithTag("LKT").GetComponent<Transform>();   
    }

    void Update()
    {
        _body.LookAt(Cam);
    }
}
