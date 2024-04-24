using TMPro;
using UnityEngine;

public class CoinBank : MonoBehaviour
{
    public static CoinBank Instance;

    [SerializeField] private int goldCount;
    [SerializeField] private TextMeshProUGUI goldCountText;
    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if(Instance == this)
        {
            Destroy(gameObject);
        }
    }
    public void UpdateGoldCountText()
    {
        goldCount++;
        goldCountText.text = goldCount.ToString();
    }
}
