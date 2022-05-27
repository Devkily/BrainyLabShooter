using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody _player;
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _rotateSpeed;
    private Shoot _shoot;

    private void Start()
    {
        _shoot = GetComponent<Shoot>();
    }
    private void Update()
    {
        Movement();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _shoot.Fire();
        }
    }
    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _player.transform.position += _player.transform.up * _movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _player.transform.position -= _player.transform.up * _movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _player.transform.Rotate(0, 0, _rotateSpeed * -1 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _player.transform.Rotate(0, 0, _rotateSpeed * Time.deltaTime);
        }
    }
}
