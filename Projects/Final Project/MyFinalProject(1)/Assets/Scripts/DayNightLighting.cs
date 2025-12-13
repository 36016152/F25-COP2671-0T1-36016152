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
        // Initialize variables and references to Time Manager
        private TimeManager manager;
        [SerializeField] private Gradient gradient;
        [SerializeField] private AnimationCurve curve;
        private new Light2D light;

        private void Awake()
        {
            // Get components needed
            light = GetComponent<Light2D>();
            manager = GetComponent<TimeManager>();
        }

        // Update is called once per frame
        void Update()
        {
            // Use the animation curve to influence the transparency of the gradient
            float curveValue = curve.Evaluate(manager.timeOfDay / manager.lengthOfDay);
            // Evaluate color at the given time of day
            Color finalColor = gradient.Evaluate(manager.timeOfDay/manager.lengthOfDay);
            light.color = finalColor;
        }
    }
}