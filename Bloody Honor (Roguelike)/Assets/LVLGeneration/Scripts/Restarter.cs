using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restarter : MonoBehaviour {

	[SerializeField] private GameObject _menuNextLvL;

    private void Start()
    {
        _menuNextLvL = GameObject.Find("NextLVL");
        _menuNextLvL.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
		_menuNextLvL.SetActive(true);
        Time.timeScale = 0;
    }
}
