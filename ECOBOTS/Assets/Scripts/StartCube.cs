using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCube : MonoBehaviour
{
    private MenuManager MM;
    
    void Start()
    {
        MM = GameObject.FindGameObjectWithTag("MM").GetComponent<MenuManager>();
    }
    private void OnMouseDown()
    {
        MM.TrackStart();
    }
  
}
