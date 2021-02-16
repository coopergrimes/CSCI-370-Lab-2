using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrarium : MonoBehaviour
{

    public GameObject particles;
    public GameObject audio;
    private ParticleSystem ps;
    private AudioSource asource;

    // Start is called before the first frame update
    void Start()
    {
        ps = particles.GetComponent<ParticleSystem>();
        asource = audio.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ps.Play();
        asource.Play();
    }
}
