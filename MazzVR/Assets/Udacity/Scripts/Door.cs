using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 

{
    public GameObject Riseup;
    public bool locked;
    public static bool hasKey = false;
    public AudioClip open;
    public AudioClip close;

    void Update() {
        // If the door is opening and it is not fully raised
        if (!locked)
        {
            if (transform.position.y <= 11.5)
            {
                transform.Translate(0, 30f * Time.deltaTime, 0, Space.World);
                Debug.Log("Unlocked!");
                Riseup.transform.Rotate(0f, 8f * Time.deltaTime, 0f);

            }
        }
        // Animate the door raising up
        
    }

    public void OnDoorClicked() {
        Debug.Log("WORKS");
        // If the door is unlocked and it is not fully raised
        if (Key.hasKey == true)
        {
            locked = false;
            AudioSource.PlayClipAtPoint(open, transform.position);
            transform.Translate(Vector3.up * 3 * Time.deltaTime, Space.World);
        }
        if (Key.hasKey == false)
        {
            AudioSource.PlayClipAtPoint(close, transform.position);

        }
      
    }
    
 
}
