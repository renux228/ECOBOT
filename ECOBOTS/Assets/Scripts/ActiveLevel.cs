using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveLevel : MonoBehaviour
{
    private Transform _point;
    private Transform _body;
    private ActiveLevel AL;
    public int Speed;
    void Start()
    {
        _body = gameObject.GetComponent<Transform>();
        _point = GameObject.FindGameObjectWithTag("PSL").GetComponent<Transform>();
        AL = gameObject.GetComponent<ActiveLevel>();
    }

    // Update is called once per frame
    void Update()
    {
        _body.position = Vector3.MoveTowards(_body.position, _point.position, Speed * Time.deltaTime);
        if (Vector3.Distance(_body.position, _point.position) < 0.2f)
        {
            AL.enabled = false;
        }
    }
}
