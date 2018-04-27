using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenu : MonoBehaviour {
    private float _progress = 0f;
    private SpriteRenderer sr;
    private float timer = 0;
    public float timeTilFade;
    private GameManager GM;

    // Use this for initialization
    void Start () {
        sr = GetComponent<SpriteRenderer>();
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= timeTilFade) {
            sr.color = new Color(255, 255, 255, Mathf.Lerp(1, 0, _progress));
            _progress += Time.deltaTime * 0.5f;
        }
        if (_progress >= 1) GM.gameStart = true;
        
    }
}
