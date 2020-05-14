using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestr : MonoBehaviour
{
    public float Sec;
    public float EndTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Sec += 1f * Time.deltaTime;
        if (Sec >= EndTime)
        {
            Destroy(gameObject);
        }
    }
}
