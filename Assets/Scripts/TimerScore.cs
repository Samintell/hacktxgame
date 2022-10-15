using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScore : MonoBehaviour
{
    private int curTime;
    private bool isRunning;

    // Start is called before the first frame update
    void Start()
    {
        isRunning = false;
        curTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning) {
            curTime += 1;
        }
        
    }

    public int getScore() {
        return (int) (curTime * 20);
    }
    
}
