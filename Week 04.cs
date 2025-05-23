using UnityEngine;

public class Week04 : MonoBehaviour
{


    bool canInteract = false;
    void OnInteract()
    {
        if(canInteract)
        {
            Debug.Log("Interacting with object.");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            canInteract = true;
            Debug.Log("Coin entered the trigger area.");
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
