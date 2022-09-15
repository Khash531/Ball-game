using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public void OnTriggerEnter (Collider collisionInfo) 
    {
        if (collisionInfo.gameObject.tag == "Coin")
        {
            collisionInfo.gameObject.SetActive(false);
        }
    }
}
