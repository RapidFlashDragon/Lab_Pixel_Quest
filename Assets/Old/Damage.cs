using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour
{

    public GameObject player;

    void OnTriggerEnter(Collider Shield)
    {
        player.gameObject.SetActive(false);
        //or
        player.GetComponent<Renderer>().enabled = false;
    }
}