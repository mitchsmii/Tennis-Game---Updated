using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingColor : MonoBehaviour
{
    public Color flashColor = Color.red;
    public float flashSpeed = 1f;

    private Material material;
    private Color originalColor;
    private bool isFlashing = false;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        originalColor = material.color;
    }

    void Update()
    {

            float lerp = Mathf.PingPong(Time.time * flashSpeed, 1);
            material.color = Color.Lerp(originalColor, flashColor, lerp);

    }
}

