using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _yPos;
    private float _speed;
    private float _ampl;

    void Start()
    {
        _yPos = Random.Range(-4f, 4f);
        _speed = Random.Range(1f, 3f);
        _ampl = Random.Range(0.5f, 2f);
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        transform.position = new Vector3(transform.position.x, _yPos + _ampl * Mathf.Sin(Time.time * _speed),transform.position.z);
    }
}
