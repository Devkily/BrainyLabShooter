using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text _playerScoreText;
    [SerializeField] TMP_Text _enemyScoreText;
    public static int _playerScore;
    public static int _enemyScore;
    private int _playerScorepref;
    private int _enemyScorepref;



    void Update()
    {
        _playerScorepref = _playerScore;
        _enemyScorepref = _enemyScore;
        if (PlayerPrefs.GetInt("_playerScore") <= _playerScorepref)
        {
            PlayerPrefs.SetInt("_playerScore", _playerScorepref);
        }
        if (PlayerPrefs.GetInt("_enemyScore") <= _enemyScorepref)
        {
            PlayerPrefs.SetInt("_enemyScore", _enemyScorepref);
        }
        _playerScoreText.text = "Player Score: " + PlayerPrefs.GetInt("_playerScore").ToString();
        _enemyScoreText.text = "Enemy Score: " + PlayerPrefs.GetInt("_enemyScore").ToString();
    }
}
