using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public GameObject NextLvl;
    public GameObject Level;
    private MenuManager MM;
    public int numNextLevel;
    public int numPassL;
    // Start is called before the first frame update
    void Start()
    {
        MM = GameObject.FindGameObjectWithTag("MM").GetComponent<MenuManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PL")
        {
            MM.LevelsActive[numPassL] = false;
            MM.LevelsActive[numNextLevel] = true;
            Level.SetActive(false);
            NextLvl.SetActive(true);
            Destroy(gameObject);
        }
    }
}
