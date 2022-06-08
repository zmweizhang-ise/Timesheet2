using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGreenLightTrigger : MonoBehaviour
{

    [SerializeField] private List<GameObject> playerList = new List<GameObject>();
    [SerializeField] private List<Rigidbody> playerInGameRbList = new List<Rigidbody>();

    [SerializeField] GameObject loseZone;
    private bool playerDetected;
    private bool playerMoved;

    private void Start()
    {
        //      playerRb = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();
        foreach (GameObject player in GameObject.FindGameObjectsWithTag("Player"))
        {
            playerList.Add(player);         //adds players to list
        }
        for (int x = 0; x < playerList.Count; x++)
        {
            playerInGameRbList.Add(playerList[x].GetComponent<Rigidbody>());     //adds rigidbod7 to  to list
        }
    }
    private void FixedUpdate()
    {
        foreach (Rigidbody playerRb in playerInGameRbList.ToArray())
        {
            if (playerRb.velocity.magnitude > 0 && playerDetected == true)
            {
                playerMoved = true;
            }
            else
            {
                playerMoved = false;
            }
        }

        foreach (GameObject players in playerList.ToArray())
        {
            if (playerMoved == true)
            {
                players.transform.position = loseZone.transform.position;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerDetected = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerDetected = false;
        }
    }
}
