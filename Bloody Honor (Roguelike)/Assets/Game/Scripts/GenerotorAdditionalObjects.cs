using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerotorAdditionalObjects : MonoBehaviour
{
    private List<int> _empoloyedObjects = new List<int>();
    private GameObject[] _floor;

    [Header("Object")]
    [SerializeField] private GameObject _spawnOBJ;
    [SerializeField] private GameObject _transitiobOGJ;

    [Header("Enemy")]
    [SerializeField] private int _maxNumberEnemys = 10;
    [SerializeField] private List<GameObject> _enemyOGJ;

    [Header("Safe")]
    [SerializeField] private int _maxSafeOGJ = 10;
    [SerializeField] private List<GameObject> _safeOBJ;

    void Start()
    {
        _floor = GameObject.FindGameObjectsWithTag("Floor");

        AdditionObject(_spawnOBJ, true);
        AdditionObject(_transitiobOGJ, true);
        int _numberEnemys = Random.Range(2, _maxNumberEnemys);
        while (_numberEnemys!=0)
        {
            AdditionObject(_enemyOGJ[Random.Range(0, _enemyOGJ.Count)], false);
            _numberEnemys--;
        }
        int _numberSafe = Random.Range(2, _maxSafeOGJ);
        while (_numberSafe != 0)
        {
            AdditionObject(_safeOBJ[Random.Range(0, _safeOBJ.Count)], true);
            _numberSafe--;
        }
    }

    private void AdditionObject(GameObject _newObject, bool _delite)
    {
        int _numberObject = Random.Range(0, _floor.Length);

        if (_empoloyedObjects != null)
        {
            for (int i = 0; i < _empoloyedObjects.Count ; i++)
            {
                if (_numberObject == _empoloyedObjects[i])
                {
                    AdditionObject(_newObject, _delite);
                }
            }
        }

        Instantiate(_newObject, new Vector3(_floor[_numberObject].transform.position.x, _floor[_numberObject].transform.position.y, -5), _floor[_numberObject].transform.rotation);

        if (_delite)
            Destroy(_floor[_numberObject]);
        

        _empoloyedObjects.Add(_numberObject);
    }

}
