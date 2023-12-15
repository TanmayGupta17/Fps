using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform BulletSpawn;
    public GameObject bulletPrefab;
    public float BulletSpeed = 50f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var Bullet = Instantiate(bulletPrefab, BulletSpawn.position, BulletSpawn.rotation);
            Bullet.GetComponent<Rigidbody>().velocity = BulletSpawn.forward * BulletSpeed;
        }
    }
}
