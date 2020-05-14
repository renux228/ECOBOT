using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private Transform Portal;
    private Transform _pl;
    private Rigidbody _rb;
    public string nameTp;
    public bool _telep;
   
    
    void Start()
    {
        Portal = GameObject.FindGameObjectWithTag(nameTp).GetComponent<Transform>();
        _rb = gameObject.GetComponent<Rigidbody>();
    }

   
    void Update()
    {
      
        if (_telep)
        {
            _rb.isKinematic = false;
            _telep=false;
            _pl.position = Portal.position;

        }
    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PL")
        {
            _pl = other.transform;
            _telep = true;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "PL")
        {
            _telep = false;
            Destroy(gameObject);
        }
      
    }

}
