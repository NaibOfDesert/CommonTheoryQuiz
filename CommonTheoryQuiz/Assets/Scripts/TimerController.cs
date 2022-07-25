using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    float timerValue;

    void Update()
    {
        UpdateTimer();
    }
    
    void UpdateTimer(){
        timerValue -= Time.deltaTime;

        if(timerValue <= 0 ){
            timerValue = timeToCompleteQuestion;
        }
        UnityEngine.Debug.Log(timerValue);
    }


}
