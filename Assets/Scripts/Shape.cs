using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shape : MonoBehaviour {
    private Rigidbody2D rb;
    public bool release;
    private GameManager GM;
    private SpriteRenderer sr;
    public GameObject Particle;
    public GameObject Tag;

    // Use this for initialization
    void Start () {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if(release == true) {
            rb.constraints = RigidbodyConstraints2D.None;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Shape") {
            GM.point += 1;
            Debug.Log("GamePoint : " + GM.point);
            Particle.SetActive(true);
            sr.color = new Color(255, 255, 255, 0);
            Destroy(Tag);
        }
        //ADD under here that if gameclear then it wont reset anymore.
        if (collision.gameObject.tag == "Reset" && !GM.levelClear) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
