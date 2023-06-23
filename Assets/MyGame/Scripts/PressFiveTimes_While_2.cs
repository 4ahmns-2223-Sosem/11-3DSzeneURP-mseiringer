using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressFiveTimes_While_2 : MonoBehaviour
{
    public GameObject Cube2; 
    public int touchCountThreshold = 5;
    public GameObject InfotextRot;
    public GameObject Infotext1;

    public Color highlightColor = Color.white;
    public float highlightDuration = 0.5f;
    private Color originalColor;
    private Renderer objectRenderer;
    private bool isHighlighted = false;

    private int touchCount = 0;

    public void Start()
    {
        InfotextRot.SetActive(false);
        Infotext1.SetActive(true);

        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Cube2)
        {
            touchCount++;

            isHighlighted = true;
            objectRenderer.material.color = highlightColor;
            Invoke("ResetColor", highlightDuration);

            if (touchCount >= touchCountThreshold)
            {
                InfotextRot.SetActive(true);
                Infotext1.SetActive(false);
                Debug.Log("Roter Text Aktiv");
               
            }
        }
    }
    private void ResetColor()
    {
        isHighlighted = false;
        objectRenderer.material.color = originalColor;
    }
}

