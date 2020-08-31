using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] int timeForWait = 3;
    int currentIndex;


    void Start()
    {
        currentIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }

    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeForWait);
        LoadNExtScene();
    }

    private void LoadNExtScene()
    {
        SceneManager.LoadScene(currentIndex + 1);
    }
}
