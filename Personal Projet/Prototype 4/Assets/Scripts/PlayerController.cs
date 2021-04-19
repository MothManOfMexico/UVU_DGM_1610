using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed;
    private GameObject focalPoint;
    

    public bool hasPowerup;
    public float powerupStrength = 16.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * Time.deltaTime);
    }

    //this block of code allows player to pickup powerup
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            Debug.Log("Powerup Collected!");

            StartCoroutine(PowerupCountdownRoutine());
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            //Gets the enemies rigidbody component so we can have access to its physics properties
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            //Gets the position of the enemy in relation to the player
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            //Report player collision with pick up
            Debug.Log("Player has collided with " + collision.gameObject + " powerup set to " + hasPowerup);
            //On Collision kicks enemy back
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }
    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7); hasPowerup = false;
    }

}
