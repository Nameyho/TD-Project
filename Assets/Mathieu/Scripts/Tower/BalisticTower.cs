using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalisticTower : Tower 
{
    #region  Exposed

    [Header("Specificité Balistique")]
    [SerializeField]
    protected GameObject _Nose;

    [SerializeField]
    private GameObject _bulletPrefab;

    [SerializeField]
    private float _delayshoot;

    private float _nextShotTime;

    [SerializeField]
    private float _bulletSpeed;

    [SerializeField]
    private float _destroyBullet;
    #endregion

    #region private

    private Transform _transform;

    #endregion

    #region Unity API
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Mob"))
        {
            if ((Time.time >= _nextShotTime))
            {
                FireBullet(other);
                _nextShotTime = Time.time + _delayshoot;
            }
            _transform.gameObject.transform.LookAt(other.transform);
        }    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mob"))
        {
            _transform.gameObject.transform.LookAt(other.transform);
        }


    }

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }
    #endregion


    #region Methods

    private void FireBullet(Collider Other)
    {

        GameObject newbullet = Instantiate(_bulletPrefab, _Nose.transform);
        newbullet.gameObject.transform.LookAt(Other.transform);
        Bullet bullet = newbullet.GetComponent<Bullet>();
        bullet.Shoot(_bulletSpeed);
        Destroy(newbullet, _destroyBullet);
    }

    #endregion

 
}
