using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class behavior : MonoBehaviour
{
    public Rigidbody projectile;
    int score;
    TextMesh scoreUI;

    void Start()
    {
        projectile = gameObject.GetComponent<Rigidbody>();
        scoreUI = GameObject.Find("Score").GetComponent<TextMesh>();
    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Catcher")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            ResetBall();
            score++;
            scoreUI.text = "Score: " + score;
            if (score >= 10)
            {
                Application.Quit();
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }

        if (collision.gameObject.name == "Floor")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            ResetBall();
        }
    }

    void ResetBall()
    {
        float newX = Random.Range(-5.0f, 5.0f);
        float newZ = Random.Range(0.0f, 3.0f);
        transform.position = new Vector3(newX, 10.0f, newZ);
    }
}
