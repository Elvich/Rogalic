using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    void Start()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y , -10);
    }

}
