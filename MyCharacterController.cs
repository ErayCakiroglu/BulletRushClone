using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float playerMoveSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /*Kendisine gelen parametreye göre oyuncuya hareket kazandırmayı sağlayan methot.*/
    protected void PlayerMove(Vector3 direction)
    {
        rb.velocity = direction * playerMoveSpeed * Time.deltaTime;
    }
}
