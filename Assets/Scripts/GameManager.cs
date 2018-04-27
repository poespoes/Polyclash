using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public SpriteRenderer LevelMenu;
    public GameObject Shape1;
    public GameObject Shape2;
    public GameObject Shape3;
    public float point = 0;
    public float level = 0;
    public bool gameStart;
    bool startCounter;
    public bool levelClear;
    float counter = 0;
    static float _progress = 0f;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        //LevelMenu.color = new Color(255, 255, 255, (Mathf.Lerp(255, 0,_progress)));
        //_progress += Time.deltaTime * 0.2f;

        if (gameStart && Input.GetKeyDown(KeyCode.Alpha1)) {
            Shape1.GetComponent<Shape>().release = true;  
        }
        if (gameStart && Input.GetKeyDown(KeyCode.Alpha2)) {
            Shape2.GetComponent<Shape>().release = true;  
        }
        if (gameStart && Input.GetKeyDown(KeyCode.Alpha3)) {
            Shape3.GetComponent<Shape>().release = true;
        }
        if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene("Menu");

        //StartCounter
        if (startCounter) counter += Time.deltaTime;

        //Level 1
        if(level == 1 && point >= 2 && !startCounter) {
            Debug.Log("Level 1 cleared");
            levelClear = true;
            startCounter = true;
            gameStart = false;
        }
        if (level == 1 && point >= 2 && counter >= 2) SceneManager.LoadScene("Level_2");

        //Level 2
        if (level == 2 && point >= 2 && !startCounter) {
            Debug.Log("Level 2 cleared");
            levelClear = true;
            startCounter = true;
            gameStart = false;
        }
        if (level == 2 && point >= 2 && counter >= 2) SceneManager.LoadScene("Level_3");
        //Level 3
        if (level == 3 && point >= 2 && !startCounter) {
            Debug.Log("Level 3 cleared");
            levelClear = true;
            startCounter = true;
            gameStart = false;
        }
        if (level == 3 && point >= 2 && counter >= 2) SceneManager.LoadScene("Level_4");
        //Level 4
        if (level == 4 && point >= 4 && !startCounter) {
            Debug.Log("Level 4 cleared");
            levelClear = true;
            startCounter = true;
            gameStart = false;
        }
        if (level == 4 && point >= 4 && counter >= 2) SceneManager.LoadScene("End");

        //FastClear
        if (level == 1 && Input.GetKeyDown(KeyCode.K)) SceneManager.LoadScene("Level_2");
        if (level == 2 && Input.GetKeyDown(KeyCode.K)) SceneManager.LoadScene("Level_3");
        if (level == 3 && Input.GetKeyDown(KeyCode.K)) SceneManager.LoadScene("Level_4");
        if (level == 4 && Input.GetKeyDown(KeyCode.K)) SceneManager.LoadScene("End");
    }
}
