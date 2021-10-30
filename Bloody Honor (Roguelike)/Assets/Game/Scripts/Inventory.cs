using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private int _maxAmountItem = 20;

    [SerializeField] private List<Item> _listItem = new List<Item>();

    public bool AddItem(Item _newItem)
    {
        if (_listItem.Count < _maxAmountItem)
        {
            _listItem.Add(_newItem);
            return true;
        }
        else
        {
            Debug.Log("Inventory filled up");
            return false;
        }
    }

    public void DelitItem(Item _delItem)
    {
        _listItem.Remove(_delItem);
    }
}
