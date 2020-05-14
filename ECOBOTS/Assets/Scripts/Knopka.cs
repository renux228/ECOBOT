using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knopka : MonoBehaviour
{
    public GameObject wal;
    public bool _active;
    public Transform NullTrans;
    public Transform Atransform;
    public int Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_active)
        {
            wal.transform.position = Vector3.MoveTowards(wal.transform.position, Atransform.position, Speed * Time.deltaTime);
        }
        else
        {
            wal.transform.position = Vector3.MoveTowards(wal.transform.position, NullTrans.position, Speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "dog")
        {
            _active = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "dog")
        {
            _active = false;
        }
    }
}
