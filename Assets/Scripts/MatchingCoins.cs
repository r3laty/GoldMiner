using UnityEngine;

public class MatchingCoins : ObjectCollision
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(neededTag))
        {
            CoinBank.Instance.UpdateGoldCountText();
            Destroy(collision.gameObject);
        }
    }
}
