using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform targetTransform;
    [SerializeField] float lerpValue;
    Vector3 distance;
    void Start()
    {
        distance = transform.position - targetTransform.position;
    }
    /*Kendisine gönderilen Transform hedefini takip eden kod parçacığı.*/
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, targetTransform.position + distance, lerpValue * Time.deltaTime);
    }
}
