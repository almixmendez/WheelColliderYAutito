using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAttack : MonoBehaviour
{
    [SerializeField] private int attackDamage = 2;
    
    private EnemyControl enemyControl;
    private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.CompareTag("Enemy"))
        {
            EnemyControl enemyControl = collision.gameObject.GetComponent<EnemyControl>();
            Debug.Log("Choqu� al enemigo!");
            enemyControl.receiveDamage();
        }
    }
}
