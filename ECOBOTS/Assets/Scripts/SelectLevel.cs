using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevel : MonoBehaviour
{
    private GameObject Menu;
    public GameObject Level;
    void Start()
    {
        Menu = GameObject.FindGameObjectWithTag("map");
    }
    private void OnMouseDown()
    {
        Level.SetActive(true);
        Menu.SetActive(false);
    }

    void Update()
    {
        
    }
}
