using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeDestroy : MonoBehaviour
{
    public GameObject woodLogs;
    public GameObject sfxSource;
    AudioClips audioClips;
    void Start()
    {
        audioClips = sfxSource.GetComponent<AudioClips>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Collector") && Input.GetKey(KeyCode.E))
        {
            Instantiate(audioClips, transform.position, Quaternion.identity).PlayTreeChopSFX();
            Instantiate(woodLogs,transform.position,Quaternion.identity);
            Instantiate(woodLogs,transform.position,Quaternion.identity);
            Instantiate(woodLogs,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
