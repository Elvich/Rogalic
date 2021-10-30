using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class EnemyBaza : MonoBehaviour
{
    [SerializeField] private int _helth = 25;
    [SerializeField] private int _damage = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Fight " + this.gameObject.name);
    }
}
