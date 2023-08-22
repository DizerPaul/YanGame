using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class _GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _gameOverScoreText;
    [SerializeField] private GameObject _gameOverWindow;
    [SerializeField] private GameObject _startWindow;

    private int _score;
    private bool _isGameStarted;


    void Start()
    {
        Time.timeScale = 0;
        _startWindow.SetActive(true);
        _gameOverWindow.SetActive(false);
        _isGameStarted = false;
    }

    private void Update()
    {
        if (!_isGameStarted && (Input.GetMouseButton(0)))
        {
            _startWindow.SetActive(false);
            _isGameStarted = true;
            StartGame();
        }
    }

    void StartGame()
    {
        Time.timeScale = 1;
        _startWindow.SetActive(false);
    }

    public void ChangeScore()
    {
        _score ++;
        _scoreText.text = "Score: " + _score.ToString();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        _gameOverWindow.SetActive(true);
        _gameOverScoreText.text = "You Score: " + _score.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
