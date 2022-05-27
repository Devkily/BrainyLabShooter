using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckAI : MonoBehaviour
{
    private Shoot _shoot;
    private void Start()
    {
        _shoot = GetComponent<Shoot>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _shoot.Fire();
        }
    }
}
