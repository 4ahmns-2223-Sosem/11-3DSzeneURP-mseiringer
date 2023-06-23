using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressFiveTimes_While : MonoBehaviour
{
    public GameObject Cube1; 
    public int touchCountThreshold = 2;
    public GameObject InfotextGruen;
    public GameObject Infotext1;

    public Color highlightColor = Color.white;
    public float highlightDuration = 0.5f;
    private Color originalColor;
    private Renderer objectRenderer;
    private bool isHighlighted = false;

    private int touchCount = 0;

    public void Start()
    {
        InfotextGruen.SetActive(false);
        Infotext1.SetActive(true);

        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Cube1)
        {
            touchCount++;

            isHighlighted = true;
            objectRenderer.material.color = highlightColor;
            Invoke("ResetColor", highlightDuration);

            if (touchCount >= touchCountThreshold)
            {
                InfotextGruen.SetActive(true);
                Infotext1.SetActive(false);
                Debug.Log("Grüner Text Aktiv");
            }
        }
    }

    private void ResetColor()
    {
        isHighlighted = false;
        objectRenderer.material.color = originalColor;
    }
}

