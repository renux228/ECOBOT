using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketShoot : MonoBehaviour
{
    public GameObject Cel;
    private Rigidbody _rb;
    public Transform _spawnPos;
    private bool _shooting;
    private ShotBot SB;
    public bool Zalp;
    void Start()
    {
        SB = GameObject.FindGameObjectWithTag("PL").GetComponent<ShotBot>();
     
      
    }

   public void Shoot()
    {
        if (!Zalp)
        {
            Ray ray = new Ray(_spawnPos.position, _spawnPos.forward * 100f);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))

            {
                GameObject g = Instantiate<GameObject>(Cel);
                g.transform.position = hit.point + hit.normal * 0.01f;
                g.transform.rotation = Quaternion.LookRotation(-hit.normal);
                SB.RunRocket();
                Zalp = true;
                //Instantiate(Cel, hit.transform.position, Quaternion.identity);
            }
        }
       

    }
    void Update()
    {
        Debug.DrawRay(_spawnPos.position, _spawnPos.forward * 100f);
     
       
    }
}
