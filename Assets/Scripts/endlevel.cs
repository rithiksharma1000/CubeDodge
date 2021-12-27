using UnityEngine;

public class endlevel : MonoBehaviour
{
    public GameManager gamemanager;
    private void OnTriggerEnter()
    {
        gamemanager.nextlevel();
    }


}
