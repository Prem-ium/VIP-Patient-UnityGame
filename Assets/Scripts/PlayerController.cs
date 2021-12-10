using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject missile;

    public bool isRunning;
    private bool isOutOfLives;
    public int lives;
    public float speed = 1;

    public float maxPos = 9.7f;
    Vector3 position;

    public int numOfMissiles;

    public TextMesh livesText;
    public TextMesh timeText;
    public TextMesh gameOverText;
    public TextMesh speedText;
    public TextMesh missilesText;

    public float timer = 0f;

    public ParticleSystem collisionParticles;

    // Start is called before the first frame update
    void Start()
    {
        isRunning = false;
        isOutOfLives = false;
        position = transform.position;
        lives = 2;
        Time.timeScale = 0;
        numOfMissiles = 2;

        StartCoroutine(addMissile());
    }

    IEnumerator addMissile()
    {
        while (true)
        {
            if (numOfMissiles < 2)
            { 
                numOfMissiles += 1;
                yield return new WaitForSeconds(15);
            }
            else
            {
                yield return null;
            }
        }
    }
    
    void gameOver()
    {
        collisionParticles.Play();
        if (lives == 0)
        {
            isOutOfLives = true;
            gameOverText.text = "GAME OVER!";
            isRunning = false;
            speed = 0;
            Time.timeScale = 0;
        }
    }
    


    // Update is called once per frame
    void Update()
    {
        
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && timer == 0f)
        {
            Time.timeScale = 1;
            isRunning = true;
        }


        if (isRunning)
        {
            speed = speed + .005f;

            // Launch a missile, provided one is available
            if (Input.GetKeyDown(KeyCode.Space) && numOfMissiles != 0)
            {
                Instantiate(missile, transform.position, missile.transform.rotation);
                numOfMissiles = numOfMissiles - 1;
                missilesText.text = "Missiles: " + numOfMissiles.ToString();
            }

            position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            position.x = Mathf.Clamp(position.x, -maxPos, maxPos);

            // A little acceleration
            position.z += speed * Time.deltaTime / 2;
            position.z = Mathf.Clamp(position.z, -maxPos, maxPos);
            transform.position = position;

            
            // Update text UI
            timer = timer + Time.deltaTime;
            timeText.text = "Time: " + timer;
            speedText.text = "Speed: " + speed.ToString();
            missilesText.text = "Missiles: " + numOfMissiles.ToString();

        }


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collisionParticles.Play();

            // Update live count
            lives = lives - 1;
            livesText.text = "Lives: " + lives.ToString();
            // Invoke a game over method if out of lives
            
            if(lives == 0)
            {
                gameOver();
            }
        } 
        /* If animals are added in the later version, they are an instant lose.
        if (collision.gameObject.tag == "AnimalEnemy")
        {
            collisionParticles.Play();
            lives = 0;
            livesText.text = "Lives: " + lives.ToString();

            gameOver();
        }*/
    }
    public float getSpeed()
    {
        return speed;
    }
}
