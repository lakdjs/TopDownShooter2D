using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingLogic : MonoBehaviour
{
    [SerializeField] private Bullets _bullet;
    [SerializeField] private Transform _firePoint;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ShootBullet(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }
    public void ShootBullet(Vector2 dir)
    {
        Bullets bullet = Instatiate(_bullet,_firePoint.position,_firePoint.rotation);
        bullet.transform.position = _firePoint.position;
        bullet.SetMoveTo(dir);
    }
}
