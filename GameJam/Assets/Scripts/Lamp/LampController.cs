using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering.Universal;

public class LampController : MonoBehaviour
{
    public Light2D lampLight;
    private float intensityIncrement = 1f;
    private float falloffIncrement = 1f;
    private float maxIntensity = 3.2f;
    private float maxFalloff = 3.5f;
    private float targetIntensity = 2.8f;
    private float targetFalloff = 2.3f;
    private bool isQPressed = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            isQPressed = true;
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            isQPressed = false;
        }

        if (isQPressed)
        {
            IncreaseParameters();
        }
        else
        {
            DecreaseParameters();
        }
    }

    void IncreaseParameters()
    {
        if (lampLight.intensity < maxIntensity)
        {
            lampLight.intensity += intensityIncrement * Time.deltaTime;
        }

        if (lampLight.intensity > maxIntensity)
        {
            lampLight.intensity = maxIntensity;
        }

        if (lampLight.shapeLightFalloffSize < maxFalloff)
        {
            lampLight.shapeLightFalloffSize += falloffIncrement * Time.deltaTime;
        }

        if (lampLight.shapeLightFalloffSize > maxFalloff)
        {
            lampLight.shapeLightFalloffSize = maxFalloff;
        }
    }

    void DecreaseParameters()
    {
        if (lampLight.intensity > targetIntensity)
        {
            lampLight.intensity -= intensityIncrement * Time.deltaTime;
        }

        if (lampLight.intensity < targetIntensity)
        {
            lampLight.intensity = targetIntensity;
        }

        if (lampLight.shapeLightFalloffSize > targetFalloff)
        {
            lampLight.shapeLightFalloffSize -= falloffIncrement * Time.deltaTime;
        }

        if (lampLight.shapeLightFalloffSize < targetFalloff)
        {
            lampLight.shapeLightFalloffSize = targetFalloff;
        }
    }
}
