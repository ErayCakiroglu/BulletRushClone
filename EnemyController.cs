using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MyCharacterController
{
    [SerializeField] PlayerController myPlayer;
    void FixedUpdate()
    {
        var delta = myPlayer.transform.position - transform.position;
        var direction = delta.normalized;
        PlayerMove(direction);
        transform.LookAt(myPlayer.transform);
    }
    /*Bullet etiketine sahip oyun objesinin Collider'ı ile tetiklenmeye girildiği zaman çalışacak methot.*/
    void OnTriggerEnter(Collider contact)
    {
        if(contact.gameObject.CompareTag("Bullet"))
        {
            gameObject.SetActive(false);
            contact.gameObject.SetActive(false);
        }
    }
}
