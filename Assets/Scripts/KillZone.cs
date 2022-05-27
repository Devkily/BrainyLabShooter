using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Score._enemyScore += 1;
            SceneManager.LoadScene(1);
        }
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            Score._playerScore += 1;
            SceneManager.LoadScene(1);
        }
    }
}
