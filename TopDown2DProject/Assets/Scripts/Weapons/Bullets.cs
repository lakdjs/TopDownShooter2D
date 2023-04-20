using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speed;
    [SerializeField] private float _destroyTime;
    
    public void Start()
    {
        Invoke("DestroyBullet", _destroyTime);
    }

    private void Update()
    {
        _rigidbody2D.AddForce(transform.right * _speed, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
        ShowEffect();
    }
    private void ShowEffect()
    {
        Debug.Log("effect");
    }
}
