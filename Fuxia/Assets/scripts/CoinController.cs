using UnityEngine;


public class CoinController : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            CoinScoreScript.coinAmount += 1;
            Destroy(other.gameObject);
            AudioManager.instance.Play("CoinPickupSound");
        }
    }
}
