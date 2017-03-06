using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keypoof;
    public GameObject door;
    public static bool hasKey;

    void Update()
	{
        //Not required, but for fun why not try adding a Key Floating Animation here :)
        transform.position = new Vector3(11f, 2.5f + Mathf.Sin(Time.time * 5.0f), 45f);

    }

    public void OnKeyClicked()
	{
        hasKey = true;
        Instantiate(keypoof, transform.position, Quaternion.Euler(270, 0, 0));
        // Instatiate the KeyPoof Prefab where this key is located
        Debug.Log("Key has been picked up!");

        // Make sure the poof animates vertically
        //door.GetComponent<Door>().Unlock();
        // Call the Unlock() method on the Door
        Destroy(gameObject,.5f);
    }

}
