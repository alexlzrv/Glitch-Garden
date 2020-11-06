using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    [SerializeField] GameObject winLabel;
    [SerializeField] float waitToLoad = 3f;

    int numberOfAttackers = 0;
    bool levelTimerFinished = false;


    private void Start() {
        winLabel.SetActive(false);
    }

    public void AttackersSpawned() {
        numberOfAttackers++;
    }

    public void AttackersKilled() {
        numberOfAttackers--;
        if (numberOfAttackers <= 0 && levelTimerFinished) {
            StartCoroutine(HandleWinCondition());
        }
    }

    IEnumerator HandleWinCondition() {
        winLabel.SetActive(true);
        yield return new WaitForSeconds(waitToLoad);
    }

    public void LevelTimerFinished() {
        levelTimerFinished = true;
        StopSpawners();
    }

    private void StopSpawners() {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawnerArray) {
            spawner.StopSpawning();
        }
    }
}
