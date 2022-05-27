using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bullet : MonoBehaviour
{
    [SerializeField] SphereCollider _collider;

    private void OnCollisionEnter(Collision collision)
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
