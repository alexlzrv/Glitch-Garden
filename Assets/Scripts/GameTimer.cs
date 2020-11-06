using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

    [Tooltip("Level time in seconds")]
    [SerializeField] float levelTime = 10f;
    bool triggeredLevelFinished = false;


    void Update() {
        TimerFinished(); 
    }

    private void TimerFinished() {
        if (triggeredLevelFinished) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        bool timerFinished = Time.timeSinceLevelLoad >= levelTime;
        if (timerFinished) {
            FindObjectOfType<LevelController>().LevelTimerFinished();
            triggeredLevelFinished = true;
        }
    } 
}
