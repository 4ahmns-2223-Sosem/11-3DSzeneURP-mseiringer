using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCircle : MonoBehaviour
{
    public Light Licht1;
    public float DimmAnzahl;
    public float DimmInterval;

    private void Start()
    {
        StartCoroutine(DimLightRoutine());
    }


    private System.Collections.IEnumerator DimLightRoutine()
    {
        while (Licht1.intensity > 0f)
        {
            yield return new WaitForSeconds(DimmInterval);


            Licht1.intensity -= DimmAnzahl;
        }
    }

}

//By Lopress
