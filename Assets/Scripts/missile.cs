using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class missile : MonoBehaviour
{
    public Text scoreText;
    public static int score = 0;
    // Use this for initialization
    void Start()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody>().velocity *= 1.1f;
    }
    void OnTriggerEnter(Collider col)
    {
        //all projectile colliding game objects should be tagged "Enemy" or whatever in inspector but that tag must be reflected in the below if conditional
        if (col.gameObject.tag == "ball")
        {
            score += 100;
            scoreText.text= "Score: " + score;
            //add an explosion or something
            //destroy the projectile that just caused the trigger collision
            Destroy(gameObject);
            Destroy(col.gameObject);


        }
    }
}
