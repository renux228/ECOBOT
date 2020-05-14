using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotCran : MonoBehaviour
{
    public string horizontalAxis = "Horizontal2";
    private float inputHorizontal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = SimpleInput.GetAxis(horizontalAxis);
        transform.Rotate(0f, inputHorizontal * 5f, 0f, Space.World);
    }
}
