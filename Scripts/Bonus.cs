using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private _GameManager _gameManager;
    [SerializeField] private float force;

    private bool _attraction = false;
    private Transform _attractionTransform;

    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<_GameManager>();
    }


    private void FixedUpdate()
    {
        if (_attraction)
        {
            Vector3 position = (_attractionTransform.position - transform.position).normalized;
            transform.Translate(position * force * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _attraction = true;
            _attractionTransform = other.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _attraction = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            _gameManager.ChangeScore();
        }
    }
}
