using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resp : MonoBehaviour
{
    private Transform _body;
    public Transform _point;

    void Start()
    {
        _body = gameObject.GetComponent<Transform>();
    }
    public void Respawn()
    {
        _body.position = _point.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "dm")
        {
            Respawn();
        }
    }
}
