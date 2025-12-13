using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering.Universal;
using UnityEngine;
using Unity.IO.LowLevel.Unsafe;

namespace WorldTime
{
    [RequireComponent(typeof(Light2D))]
    public class WorldLight : MonoBehaviour
    {
        private TimeManager manager;

        [SerializeField] private Gradient gradient;
        [SerializeField] private AnimationCurve curve;
        private new Light2D light;

        private void Awake()
        {
            light = GetComponent<Light2D>();
            manager = GetComponent<TimeManager>();
        }

        // Update is called once per frame
        void Update()
        {
            // Use the animation curve to control how 'time' samples the gradient
            float curveValue = curve.Evaluate(manager.timeOfDay / manager.lengthOfDay);
            Color finalColor = gradient.Evaluate(manager.timeOfDay/manager.lengthOfDay);
            Debug.Log(manager.timeOfDay / manager.lengthOfDay);
            light.color = finalColor;
        }
    }
}