using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private _GameManager _gameManager;
    

    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<_GameManager>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _gameManager.GameOver();
        }
    }
}
