using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place_obj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject stone = stone_1();

        for (int i = 0; i < 5; i++)
        {
            // Position des Objekts ändern
            Vector3 newPosition = GetNewPosition(i);

            // Objekt an der neuen Position erstellen
            GameObject clonedObject = Create3DObject(stone, newPosition);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static GameObject stone_1()
    {
      
        return new GameObject();
    }

    public static GameObject Create3DObject(GameObject originalObject, Vector3 position)
    {
       
        return Instantiate(originalObject, position);
    }

    private static GameObject Instantiate(GameObject originalObject, Vector3 position)
    {
        throw new NotImplementedException();
    }

    public static Vector3 GetNewPosition(int index)
    {
        return new Vector3(index * 3, index * 2, index * 2);
    }
}
