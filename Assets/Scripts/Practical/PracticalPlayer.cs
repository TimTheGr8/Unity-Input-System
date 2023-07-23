using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PracticalPlayer : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;
    [SerializeField]
    private float _shotCoolDownTimer = 0.5f;
    [SerializeField]
    private GameObject _projectilePrefab;

    private bool _canShoot = true;
    private int _currentAmmo = 3;

    public void Move(Vector2 direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime);
    }

    public void Fire()
    {
        if (_canShoot && _currentAmmo > 0)
        {
            _canShoot = false;
            _currentAmmo--;
            Instantiate(_projectilePrefab, transform.position, Quaternion.identity);
            StartCoroutine(ShotCoolDown());
        }
    }

    IEnumerator ShotCoolDown()
    {
        yield return new WaitForSeconds(_shotCoolDownTimer);
        _canShoot = true;
    }
}
