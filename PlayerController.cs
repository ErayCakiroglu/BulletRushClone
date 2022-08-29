using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MyCharacterController
{
    [SerializeField] ScreenTouchController input;
    [SerializeField] ShootController shootController;

    void FixedUpdate()
    {
        var direction = new Vector3(input.Direction.x, 0f, input.Direction.y);
        PlayerMove(direction);
    }

    /*Enemy etiketine sahip bir oyun objesinin Collider'ı ile etkileşim oluştuğu zaman çalışacak methot.*/
    void OnCollisionEnter(Collision contact)
    {
        if(contact.gameObject.CompareTag("Enemy"))
        {
            PlayerDead();
        }
    }

    /*Enemy etiketine sahip bir oyun objesinin Collider'ı ile tetiklenme oluştuğu zaman kurşun oluşturan methot.*/
    void OnTriggerEnter(Collider contact)
    {
        if(contact.gameObject.CompareTag("Enemy"))
        {
            var direction = contact.transform.position - transform.position;
            direction.y = 0;
            direction = direction.normalized;
            shootController.Shoot(direction, transform.position);
        }
    }

    /*Oyun içi zamanı durdurmaya yarayan methot.*/
    void PlayerDead()
    {
        Time.timeScale = 0;
    }
}
