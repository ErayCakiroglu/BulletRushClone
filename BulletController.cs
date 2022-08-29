using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 movement;
    /*Kendisine gelen parametreye doğru ilerlemeye yarayan methot.*/
    public void Fire(Vector3 direction)
    {
        movement = direction * speed;
    }

    void FixedUpdate()
    {
        transform.position += movement * Time.deltaTime;
    }
}
