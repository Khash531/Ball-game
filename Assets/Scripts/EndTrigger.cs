using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public float CompleteDelay = 2f;
    
    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
