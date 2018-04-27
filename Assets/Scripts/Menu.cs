using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    bool screenSwap = false;
    public SpriteRenderer screen;

    // Use this for initialization
    void Start () {
        GetComponent<SpriteRenderer>().sortingOrder = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKeyDown(KeyCode.Space)) && screenSwap == true) {
            SceneManager.LoadScene("Level_1");
        }

        if (Input.GetKeyUp(KeyCode.Space)) {
            screen.sortingOrder = 3;
            screenSwap = true;
        }


	}
}