using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsSound : MonoBehaviour {

    [SerializeField] public Transform[] Feet;
    Collider[] FeetCol;
    bool[] FeetOnGround; // checks collision with ground...
    bool[] FeetOnGroundLastFrame; // and remebers it to only play sound once for each new collision

    [SerializeField] Transform Ground1; // "the" ground. If you have different types of grounds (e.g. stone, wood), you will need to extend this script
    Collider GroundCol; 
    [SerializeField] AudioClip[] footstepSounds1; // all footsteps sound files (maybe 4 different ones to ensure some variation)
    [SerializeField] AudioSource audioSource; // link to any audio source

    // Use this for initialization
    void Start () {
        // get feet colliders
        FeetCol = new Collider[Feet.Length];
        for (int i = 0; i < Feet.Length;  i++)
        {
            FeetCol[i] = Feet[i].GetComponent<Collider>();
        }

        // get object colliders
        GroundCol = Ground1.GetComponent<Collider>();

        FeetOnGround = new bool[Feet.Length];
        FeetOnGroundLastFrame = new bool[Feet.Length];
    }
	
	// Update is called once per frame
	void Update () {
        // instead of checking the bounds, one could also use "OnCollisionEnter". However, this seems to require one script per foot, and cannot be integrated into a single script as done here.
        for (int i = 0; i < FeetCol.Length; i++)
        {
            FeetOnGroundLastFrame[i] = FeetOnGround[i]; // store last frame's value to compare
            FeetOnGround[i] = false; // first set back to false and only to true if actually intersecting
            if (FeetCol[i].bounds.Intersects(GroundCol.bounds))
            {
                FeetOnGround[i] = true;
            }

            if (FeetOnGroundLastFrame[i] == false && FeetOnGround[i] == true)
            {
                int randomSound = Random.Range(0, 3); // randomly pick one of the sound snipplets: (0, 3) if you have 4 sound clips
                float randomVolume = Random.Range(.4f, .7f); // create some random variation in volume of the sound
                audioSource.PlayOneShot(footstepSounds1[randomSound], randomVolume); // play sound
            }
        }
    }
}
