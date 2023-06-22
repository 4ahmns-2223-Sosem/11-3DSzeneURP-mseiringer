using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneManangerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneSwitch();
        }
    }



    private void SceneSwitch()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("Scene switcht");
    }
}