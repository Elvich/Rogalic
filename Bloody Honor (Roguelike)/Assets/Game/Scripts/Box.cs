using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private Item _item;
    [SerializeField] private GameObject _sprite1;
    [SerializeField] private GameObject _sprite2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool _end = collision.gameObject.GetComponent<Inventory>().AddItem(_item);
        if (_end)
        {
            _sprite1.SetActive(false);
            _sprite2.SetActive(true);
        }
        
    }
}
