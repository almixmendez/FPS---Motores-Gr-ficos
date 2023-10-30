using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    private float maxTime;
    private float currentTime;
    private bool startTime = false;

    private void Update()
    {
        
    }

    private void OnBeforeTransformParentChanged()
    {
        currentTime -= Time.deltaTime;

        if(currentTime <= 0)
        {
            startTime = false;
        }
    }
}
