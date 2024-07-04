using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject OnCollectEffect;
    // Start is called before the first frame update
    void Start()
    {
        
        try
        {
            
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex);
            throw;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        try
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex);
            throw;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(OnCollectEffect, transform.position, transform.rotation);
        }
    }

}
