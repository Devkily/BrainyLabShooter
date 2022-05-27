using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _rotateSpeed;
    private float _timer;
    private int _action;
    enum Direction { Up, Down, Left, Right };
    Direction[] direction = { Direction.Up, Direction.Down, Direction.Left, Direction.Right };
    private void RandomBehaviour()
    {
        Direction selection = direction[Random.Range(0, 4)];
        if (selection == Direction.Up)
        {
            _action = 1;
        }
        if (selection == Direction.Down)
        {
            _action = 2;
        }
        if (selection == Direction.Right)
        {
            _action = 3;
        }
        if (selection == Direction.Left)
        {
            _action = 4;
        }
    }
    private void Update()
    {
        if (_timer <= 0)
        {
            _timer += Random.Range(0.2f, 0.5f);
            RandomBehaviour();
        }
        if (_action == 1)
        {
            MoveForward();
        }
        if (_action == 2)
        {
            MoveBack();
        }
        if (_action == 3)
        {
            RotateRight();
        }
        if (_action == 4)
        {
            RotateLeft();
        }
    }
    private void MoveForward()
    {
        _rb.transform.position += _rb.transform.up * _movementSpeed * Time.deltaTime;
        _timer -= Time.deltaTime;
    }
    private void MoveBack()
    {
        _rb.transform.position -= _rb.transform.up * _movementSpeed * Time.deltaTime;
        _timer -= Time.deltaTime * 2;
    }
    private void RotateRight()
    {
        _rb.transform.Rotate(0, 0, _rotateSpeed * -1 * Time.deltaTime);
        _timer -= Time.deltaTime;
    }
    private void RotateLeft()
    {
        _rb.transform.Rotate(0, 0, _rotateSpeed * Time.deltaTime);
        _timer -= Time.deltaTime;
    }



}
