using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFalling : MonoBehaviour
{


    
    [SerializeField] float timer;
    [SerializeField] float minimumRange, maximumRange;
    [SerializeField] float randNum;

    [SerializeField] ObjectSelector objectSelector;
    private void CalculateRange()
    {
        randNum = Random.Range(minimumRange, maximumRange); 
    }
    

    public void Start()
    {
        //InvokeRepeating("CalculateRange", 0f, 2f);
        CalculateRange();
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer>=randNum)
        {
            timer = 0;
            CalculateRange();
            Rigidbody rb = objectSelector.SelectObject();
            rb.useGravity = true;
            rb.isKinematic = false;
        }
    }
}
