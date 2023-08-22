using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    void FixedUpdate()
    {
        transform.position += new Vector3(_speed, 0, 0);
        Jump();
    }

    private void Jump()
    {
        if (Input.GetMouseButton(0)) 
        {    
            Rigidbody2D _rb = GetComponent<Rigidbody2D>();
            _rb.AddForce(Vector2.up * _jumpForce);
        }
    }
}
