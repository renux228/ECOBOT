using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private RocketShoot RS;
    public bool ShotingActive;
    void Start()
    {
        RS = GameObject.FindGameObjectWithTag("RS").GetComponent<RocketShoot>();
        if (ShotingActive)
        {
            RS.enabled = true;
        }
    }

   
    void Update()
    {
        
    }
}
