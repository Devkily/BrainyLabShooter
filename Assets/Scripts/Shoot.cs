using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform _firePoint;
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] float _bulletLiveTime = 3f;
    [SerializeField] float _shotSpeed = 10f;
    public void Fire()
    {
        GameObject bullet = Instantiate(_bulletPrefab, _firePoint.position, _firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(_firePoint.up * _shotSpeed, ForceMode.Impulse);
        Destroy(bullet, _bulletLiveTime);

    }
}
