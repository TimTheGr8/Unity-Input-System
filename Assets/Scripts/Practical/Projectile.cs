using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5.0f;

    private void Start()
    {
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        while(transform.position.y < 8)
        {
            transform.Translate(Vector3.up * (_speed * Time.deltaTime));
            yield return null;
        }
        Destroy(this.gameObject);
    }
}
