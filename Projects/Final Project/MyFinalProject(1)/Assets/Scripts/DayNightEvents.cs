using System;
using UnityEngine;

public class DayNightManager : MonoBehaviour
{
    // Create manager singleton
    public static DayNightManager current;

    private void Awake()
    {
        current = this;
    }

    // Initialize Triggers
    public event Action onSunriseTrigger;
    public event Action onSunsetTrigger;

    public void SunriseTrigger()
    {
        if (onSunriseTrigger != null)
        {
            onSunriseTrigger();
        }
    }

    public void SunsetTrigger()
    {
        if (onSunsetTrigger != null)
        {
            onSunsetTrigger();
        }
    }
}
