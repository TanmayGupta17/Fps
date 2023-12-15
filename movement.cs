using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField]
    private pistol pistol;

    public void OnShoot()
    {
        pistol.Shoot();
    }
}
