using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("In seconds")] [SerializeField] float baseLevelTime = 60f;
    float levelTime;
    bool trigger = false;

    private void Start()
    {
        levelTime = baseLevelTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        bool timerFinished = Time.timeSinceLevelLoad >= levelTime;
        if (timerFinished)
        {
            FindObjectOfType<LevelController>().TimerFinished();
            trigger = true;
        }
    }
}
