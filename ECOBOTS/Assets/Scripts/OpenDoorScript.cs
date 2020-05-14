using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoorScript : MonoBehaviour
{
    public Scrollbar _sc;
    public Transform NullPos;
    public Transform ClosePos;
    private Transform _body;
    public float Speed;
    void Start()
    {
        _body = gameObject.GetComponent<Transform>();
        
    }

 
    void Update()
    {
        if (_sc.value == 1)
        {
            _body.position = Vector3.MoveTowards(_body.position, ClosePos.position, Speed * Time.deltaTime);
        }
        else
        {
            _body.position = Vector3.MoveTowards(_body.position, NullPos.position, Speed * Time.deltaTime);
        }
    }
}
