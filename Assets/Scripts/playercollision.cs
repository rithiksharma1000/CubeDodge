using UnityEngine;

public class playercollision : MonoBehaviour
{
    public PlayerMovement movement;
    private void OnCollisionEnter(Collision collisioninfo)
    {
        if(collisioninfo.collider.tag.Equals("Obstacle"))
        {
            //fuckmovement.enabled = false;
            //FindObjectOfType<GameManager>().EndGame();

        }
      
    }

}
