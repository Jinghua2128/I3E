using UnityEngine;

public class balls : MonoBehaviour
{   
    int playerHealth = 10;
    int maxPlayerHealth = 100;

/*    void OnCollisionEnter(Collision collision)
    {

        Debug.Log(CalculateArea(5.0f, 10.0f));
        Debug.Log(CalculateArea(3.2f, 6.8f));
        Debug.Log(CalculateArea(4.4f, 9.4f));
        


    void OnInteract()
    {
        Debug.Log("Interacted");
    }

    float CalculateArea(float width, float height)
    {
        return width * height;
    }
    */
    public int score = 0;
    private CoinBehaviour nearbyCoin;

    public void ModifyScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && nearbyCoin != null)
        {
            nearbyCoin.Collect(this);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            CoinBehaviour coin = other.GetComponent<CoinBehaviour>();
            if (coin != null)
            {
                nearbyCoin = coin;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            if (other.GetComponent<CoinBehaviour>() == nearbyCoin)
            {
                nearbyCoin = null;
            }
        }
    }

}
