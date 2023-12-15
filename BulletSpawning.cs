using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawning : MonoBehaviour
{
    [SerializeField] private float Damage;
    public float life = 3;
    RaycastHit hitInfo;
    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollision(Collision collision)
    {
        if (hitInfo.collider.gameObject.TryGetComponent(out Target CubeHit))
        {
            CubeHit.SubtractHealth(Damage);
            Debug.Log(CubeHit.health);
            Destroy(collision.gameObject);
        }
    }

}
