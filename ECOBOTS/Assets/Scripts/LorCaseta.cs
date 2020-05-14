using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LorCaseta : MonoBehaviour
{
    public GameObject SpriteText;
    private void OnMouseDown()
    {
        SpriteText.SetActive(true);
    }
    public void ClosePanel()
    {
        SpriteText.SetActive(false);
    }
 
}
