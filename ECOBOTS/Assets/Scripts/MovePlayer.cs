using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";
    private float inputHorizontal;
    private float inputVertical;
    private Rigidbody m_rigidbody;
    private Transform _trans;
    public Animator _an;
    public float Speed;


    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
      
    }

    void Update()
    {
        inputHorizontal = SimpleInput.GetAxis(horizontalAxis);
        inputVertical = SimpleInput.GetAxis(verticalAxis);
        Vector3 runMove = new Vector3(inputHorizontal, 0, inputVertical);
        m_rigidbody.velocity = runMove * Speed;
        if (inputHorizontal != 0 && inputVertical != 0)
        {
            m_rigidbody.transform.eulerAngles = new Vector3(m_rigidbody.transform.eulerAngles.x, Mathf.Atan2(inputHorizontal, inputVertical) * Mathf.Rad2Deg, m_rigidbody.transform.eulerAngles.z);
        }
        if(inputHorizontal!=0 && inputVertical != 0)
        {
            _an.enabled = true;
        }
        else
        {
            _an.enabled = false;
        }
    }
    private void FixedUpdate()
    {
       
        //m_rigidbody.transform.Translate(inputVertical, 0, -inputHorizontal);
        //m_rigidbody.transform.Rotate(0f, inputHorizontal * 25f, 0f, Space.World);
    }

}
