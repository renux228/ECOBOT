using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapNextLevel : MonoBehaviour
{
    private MenuManager MM;
    public GameObject[] Levels;
    // Start is called before the first frame update
    void Start()
    {
        MM = GameObject.FindGameObjectWithTag("MM").GetComponent<MenuManager>();
    }

    // Update is called once per frame
    void Update()
    {
      for(int i = 0; i < Levels.Length; i++)
        {
            Levels[i].SetActive(MM.LevelsActive[i]);
        }
    }
}
