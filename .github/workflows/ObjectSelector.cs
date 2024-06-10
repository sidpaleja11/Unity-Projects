using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    [SerializeField] List<Rigidbody> fallingObjects;

    Rigidbody currentFallingObject;
    public Rigidbody SelectObject()
    {
        int randomNumber;
        randomNumber = UnityEngine.Random.Range(0, fallingObjects.Count);
        currentFallingObject = fallingObjects[randomNumber];
        fallingObjects.RemoveAt(randomNumber);
        return currentFallingObject;
    }

    
}
