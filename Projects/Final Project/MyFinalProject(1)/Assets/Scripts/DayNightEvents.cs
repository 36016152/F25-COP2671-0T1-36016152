using System;
using UnityEngine;

public class DayNightManager : MonoBehaviour
{
    public static DayNightManager current;

    private void Awake()
    {
        current = this;
    }

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
