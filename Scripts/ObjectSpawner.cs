using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ObjectSpawner : MonoBehaviour
{

    [SerializeField] private Camera _camera;
    
    [SerializeField] private GameObject _bonusPrefab;
    [SerializeField] private GameObject _enemyPrefab;

    [SerializeField] private float _spawnDistance;
    [SerializeField] private float _spawnHeight;

    [Range(0.5f, 2f)] public float timeToSpawn;

    private float _timer;

    void Start()
    {
        _timer = timeToSpawn;
    }

    void Update()
    {
        SpawnBonus();
        SpawnEnemy();
    }

    void SpawnBonus()
    {
        if(_timer <= 0)
        {
            _timer = timeToSpawn;
            float x = _camera.transform.position.x + Random.Range(20f,_spawnDistance);
            float y = Random.Range(_spawnHeight, -_spawnHeight);
            Vector3 spawnPosition = new Vector3(x, y, 0f);
            GameObject newBonus = Instantiate(_bonusPrefab, spawnPosition, Quaternion.identity);
            Destroy(newBonus, 6f);
        }
        else
        {
            _timer -= Time.deltaTime;
        }
    }

    void SpawnEnemy()
    {
        if(_timer <= 0)
        {
            _timer = timeToSpawn;
            float x = _camera.transform.position.x + Random.Range(20f,_spawnDistance);
            float y = Random.Range(_spawnHeight, -_spawnHeight);
            Vector3 spawnPosition = new Vector3(x, y, 0f);
            GameObject newBonus = Instantiate(_enemyPrefab, spawnPosition, Quaternion.identity);
            Destroy(newBonus, 6f);
        }
        else
        {
            _timer -= Time.deltaTime;
        }
        
    }
    
}
