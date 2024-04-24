using UnityEngine;

public class MatchingCoins : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            CoinBank.Instance.UpdateGoldCountText();
            Destroy(collision.gameObject);
        }
    }
}
