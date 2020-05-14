using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseLorCas : MonoBehaviour
{
    public GameObject Panelka;
    private void OnMouseDown()
    {
        Panelka.SetActive(false);
    }
   
}
