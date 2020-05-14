using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    public Transform[] Points;
    public Transform SpawnTrup;
    public GameObject Trup;
    private Transform _body;
    public int Speed;
    private int num;
    private int _randomInt;
    public bool _agro;
    private Transform _player;
    void Start()
    {
        _body = gameObject.GetComponent<Transform>();
        _player = GameObject.FindGameObjectWithTag("PL").GetComponent<Transform>();
    }
    public void Randomer()
    {
        num = Random.Range(0, Points.Length);
    }
  
    void Update()
    {
        if (!_agro)
        {
            Vector3 _rot = new Vector3(Points[num].position.x, _body.position.y, Points[num].position.z);
            _body.position = Vector3.MoveTowards(_body.position, Points[num].position, Speed * Time.deltaTime);
            _body.LookAt(_rot);
            if (Vector3.Distance(_body.position, Points[num].position) < 0.2f)
            {
                Randomer();
            }
        }
        else
        {
            Vector3 _rot = new Vector3(_player.position.x, _body.position.y, _player.position.z);
            _body.LookAt(_rot);
            _body.position = Vector3.MoveTowards(_body.position, _player.position, Speed * Time.deltaTime);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PL")
        {
            _agro = true;
        }
        if (other.tag == "rocket")
        {
            Instantiate(Trup, SpawnTrup.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        _agro = false;
    }
}
