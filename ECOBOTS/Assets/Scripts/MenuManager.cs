using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public bool[] LevelsActive;
    public GameObject MenuLevel;
    public GameObject UUI;
    void Start()
    {
        
    }
    public void TrackStart()
    {
        MenuLevel.SetActive(true);
        UUI.SetActive(false);
    }
   
  
}
