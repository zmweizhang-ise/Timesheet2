using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    private float speed = 50f;

    [SerializeField] private Rigidbody projectilePrefab;

    [SerializeField] private Transform firePosition;


    public void Fire()
    {
        Rigidbody rdProjectile;
        rdProjectile = Instantiate(projectilePrefab, firePosition.position, firePosition.rotation);

        rdProjectile.AddForce(transform.up * speed, ForceMode.Impulse);
    }
}
