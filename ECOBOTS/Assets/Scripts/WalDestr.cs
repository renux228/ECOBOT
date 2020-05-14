using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalDestr : MonoBehaviour
{
    public GameObject DestrSten;
    public Transform _body;
    public string Tags;

    void Start()
    {
    
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == Tags)
        {
            Instantiate(DestrSten, _body.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
