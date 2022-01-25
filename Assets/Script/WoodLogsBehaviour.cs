using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodLogsBehaviour : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject player;
    public GameObject audioSource;
    PlayerRescources rescources;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rescources = player.GetComponent<PlayerRescources>();
        rb.velocity = new Vector2(Random.Range(-2,2),Random.Range(2,6));
    }

    // Update is called once per frame
    void Update()
    {
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collector"))
        {
            rescources.AddWood();
            Instantiate(audioSource, transform.position, Quaternion.identity).GetComponent<AudioClips>().PlayCollectSFX();
            Destroy(gameObject);
        }
    }
}
