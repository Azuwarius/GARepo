using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;

    void OnCollision2dEnter()
    {
        gameManager.CompleteLevel();
    }

}
