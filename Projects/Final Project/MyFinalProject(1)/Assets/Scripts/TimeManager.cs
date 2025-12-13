using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float lengthOfDay;
    public float timeOfDay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DayNightManager.current.onSunriseTrigger += Sunrise;
        DayNightManager.current.onSunsetTrigger += Sunset;
        StartCoroutine(DayTimer());
    }

    private void Sunrise()
    {
        Debug.Log("The sun rose!");
    }
    private void Sunset()
    {
        Debug.Log("The sun has set!");
    }

    IEnumerator DayTimer()
    {
        while (true)
        {
            // Iterate on the time of day and reset when it has met the length of day
            ++timeOfDay;

            if (timeOfDay == lengthOfDay)
            {
                timeOfDay = 0.0f;
            }
            yield return null;
        }
    }


    // Update is called once per frame
    void Update()
    {
        // Trigger sunrise and sunset at 6 am and 6 pm
        if (timeOfDay == (lengthOfDay/4))
        {
            DayNightManager.current.SunriseTrigger();
        }

        if (timeOfDay == (lengthOfDay/4) * 3)
        {
            DayNightManager.current.SunsetTrigger();
        }
    }
}
