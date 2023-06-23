using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speedUp;
    float speedDown;
    float liftSpeed;

    [SerializeField] private AudioClip alarm;
    [SerializeField] public Transform liftControl;
    [SerializeField] private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        speedUp = 5.0F;
        speedDown = 5.0F;
        liftSpeed = 3.0F;

        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            {
                Debug.LogError("Error in AudioSource");
            }
        else
        {
            audioSource.clip = alarm;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moving the forklift forward and backward
        if(Input.GetKey("w")){
            transform.Translate(0,0,(speedUp*Time.deltaTime));
        }

        if(Input.GetKey("s")){
            transform.Translate(0,0,(-speedDown*Time.deltaTime));
            //audioSource.clip = alarm;
            audioSource.Stop();
            audioSource.Play();
        }    
        Debug.Log(audioSource.time);

        //Moving the forks

        if(Input.GetKey(KeyCode.R)){
            transform.Translate(0,0,(liftSpeed*Time.deltaTime));
        }

        if(Input.GetKey(KeyCode.T)){
            transform.Translate(0,0,(-liftSpeed*Time.deltaTime));
        }  

        /*
        if (moveForksUp && forks.transform.localPosition.y <= maxLiftHeight)
        {
            forks.transform.localPosition = new Vector2(forks.transform.localPosition.x, forks.transform.localPosition.y + liftingSpeed * Time.fixedDeltaTime);
            liftableMast.transform.localPosition = new Vector2(liftableMast.transform.localPosition.x, liftableMast.transform.localPosition.y + liftingSpeed / 1.5f * Time.fixedDeltaTime);
        }
        else if (moveForksDown && forks.transform.localPosition.y >= minLiftHeight)
        {
            forks.transform.localPosition = new Vector2(forks.transform.localPosition.x, forks.transform.localPosition.y - liftingSpeed * Time.fixedDeltaTime);
            liftableMast.transform.localPosition = new Vector2(liftableMast.transform.localPosition.x, liftableMast.transform.localPosition.y - liftingSpeed / 1.5f * Time.fixedDeltaTime);
        */

        
    }
}

/*  boolean isPlaying = false;
 
        IEnumerator PlaySounds() {
            if (isPlaying) return;
            isPlaying = true;
 
            // Play a sound here
            yield return new WaitForSeconds(2);
            // Play second sound here
            yield return new WaitForSeconds(4.2);
            isPlaying = false;
        }

*/