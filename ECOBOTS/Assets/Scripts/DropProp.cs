using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropProp : MonoBehaviour
{
    private ManagerArMec MAM;
    private Rigidbody _body;
    private Transform _dropPos;
    private bool _take;
    void Start()
    {
        MAM = GameObject.FindGameObjectWithTag("DropTrans").GetComponent<ManagerArMec>();
        _dropPos = MAM.transform;
        _body = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_take)
        {
            _body.transform.position = _dropPos.position;
            _body.transform.rotation = _dropPos.rotation;
        }
    }
    private void OnMouseDown()
    {
        if (MAM.TakeOb == false)
        {
            MAM.TakeOb = true;
            _take = true;
            _body.useGravity = false;
        }
        else
        {
            MAM.TakeOb = false;
            _take = false;
            _body.useGravity = true;
            _body.AddForce(_body.transform.forward * 700);
        }
    }
}
