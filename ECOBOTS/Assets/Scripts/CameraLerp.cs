using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLerp : MonoBehaviour
{
    private Transform _target;
    private Transform _body;
    private Transform _playerTrans;
    public float Speed;
    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("targetCam").transform;
        _body = gameObject.GetComponent<Transform>();
        _playerTrans= GameObject.FindGameObjectWithTag("PL").transform;
    }

   
    void FixedUpdate()
    {
        _body.LookAt(_playerTrans);
        _body.position = Vector3.Lerp(_body.position, _target.position, Speed*Time.deltaTime);
        
    }
}
