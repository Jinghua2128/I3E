using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    public int coinValue = 10;

    public void Collect(balls player)
    {
        player.ModifyScore(coinValue);
        Destroy(gameObject); // Destroy the coin
    }
}
