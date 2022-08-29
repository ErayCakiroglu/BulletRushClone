using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    [SerializeField] BulletController bulletPrefab;
    /*Kendisine parametre olarak gönderilen yön ve pozisyon değerlerine göre kurşun oluşturan methot.*/
    public void Shoot(Vector3 direction, Vector3 position)
    {
        var bullet = Instantiate(bulletPrefab, position, Quaternion.identity);
        bullet.Fire(direction);
    }
}
