using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snarad : MonoBehaviour
{
    public int Speed;
    private Transform _body;
    public Transform[] _points;
    public int _num;
    public GameObject Sled;
    private RocketShoot RS;
    // Start is called before the first frame update
    void Start()
    {
        RS = GameObject.FindGameObjectWithTag("RS").GetComponent<RocketShoot>();
        _body = gameObject.GetComponent<Transform>();
        _points[0] = GameObject.FindGameObjectWithTag("p0").GetComponent<Transform>();
        _points[1] = GameObject.FindGameObjectWithTag("p1").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        _body.position = Vector3.MoveTowards(_body.position, _points[_num].position, Speed * Time.deltaTime);
        _body.LookAt(_points[_num].position);
        if (Vector3.Distance(_body.position, _points[_num].position) < 0.2f)
        {
            if (_num < 1)
            {
                _num += 1;
            }
            else
            {
                Destroy(_points[1].gameObject);
                RS.Zalp = false;
                Instantiate(Sled, _body.position, Quaternion.identity);
                Destroy(gameObject);
              
             
            }
            

        }
    }
}
