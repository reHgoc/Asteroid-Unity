using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 20f;

    private void Start()
    {
        Invoke("DestroyBullet", 0.54f);
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.up * speed * Time.fixedDeltaTime);
    }

    void DestroyBullet()
    {
        Destroy(this.gameObject);
    }
}
