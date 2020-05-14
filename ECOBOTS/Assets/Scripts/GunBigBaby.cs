using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBigBaby : MonoBehaviour
{
    private bool _shoting;
    private bool _Zarad;
    public Transform SpawnPoint;
    private GameObject Snarad;
    private Rigidbody _rb;
    private Transform _gun;
    public int Speed;
    void Start()
    {
        _gun = gameObject.GetComponent<Transform>();
    }

    public void Shoot()
    {
        _rb.useGravity = true;
        _rb.AddForce(_rb.transform.forward * 2000);
        _Zarad = false;
    }
    void Update()
    {
        if (_Zarad)
        {
            Snarad.transform.position = SpawnPoint.position;
            Snarad.transform.rotation = SpawnPoint.rotation;
            _rb.useGravity = false;
        }
        if (SimpleInput.GetButton("L"))
        {
            _gun.Rotate(0, 0, Speed * Time.deltaTime);
        }
        if (SimpleInput.GetButton("R"))
        {
            _gun.Rotate(0, 0, -Speed * Time.deltaTime);
        }
        if (SimpleInput.GetButton("T"))
        {
            _gun.Rotate(-Speed * Time.deltaTime, 0, 0);
        }
        if (SimpleInput.GetButton("D"))
        {
            _gun.Rotate(Speed * Time.deltaTime, 0, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "snar")
        {
            Snarad = other.gameObject;
            _rb = other.gameObject.GetComponent<Rigidbody>();
            _Zarad = true;
            other.gameObject.GetComponent<DropProp>().enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<DropProp>().enabled = true;
        _Zarad = false;
        _rb = null;
    }
}

