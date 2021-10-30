using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLVL : MonoBehaviour
{
    public void Yes()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }

    public void No()
    {
        this.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

}
