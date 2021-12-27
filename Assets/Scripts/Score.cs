using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoretext;
    public Transform player;
    public PlayerMovement movement;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if(movement.enabled)
        { 
            scoretext.text = ((player.transform.position.z) / 4).ToString("0");
        }
	}
}
