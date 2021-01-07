using UnityEngine;
using UnityEngine.UI;


public class CoinScoreScript : MonoBehaviour
{

    Text text;
    public static int coinAmount;
    public static int totalCoins;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        coinAmount = 0;
        totalCoins = GameObject.FindGameObjectsWithTag("coin").Length;
    }

    // Update is called once per frame
    private void Update()
    {
        text.text = coinAmount.ToString() + "/" + totalCoins;
    }
}