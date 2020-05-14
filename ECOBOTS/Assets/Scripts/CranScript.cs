using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CranScript : MonoBehaviour
{
    private GameObject _ob;
    public bool _tike;
    public bool _trigg;
    public Transform _point;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SimpleInput.GetButton("J")&&_trigg)
        {
            _tike = true;
        }
        if (_tike)
        {
            _ob.transform.position = _point.position;
            _ob.GetComponent<Rigidbody>().useGravity = false;
        }
        if (SimpleInput.GetButton("P"))
        {
            if (!_ob == false){
                _ob.GetComponent<Rigidbody>().useGravity = true;
                _tike = false;
            }
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "dog")
        {
            _ob = other.gameObject;
            _trigg = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "dog")
        {
            _ob = null;
            _trigg = false;
            _tike = false;
        }
    }
}
