using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class Tile : MonoBehaviour {
    public int x, y;
    public bool isMine = false;
    public bool isRevealed = false;
    [Header("Referencesc")]
    public Sprite[] emptySprites;
    public Sprite[] mineSprites;
    private SpriteRenderer rend;

	// Use this for initialization
	void Start () {
		
	}
    
    void awake() {
        rend = GetComponent<SpriteRenderer>();
    }


    public void Reveal(int adjacentMines, int mineState = 0) {
        isRevealed = true;
        if (isMine)
        {
            rend.sprite = mineSprites[mineState];
        }
        else
        {
            rend.sprite = emptySprites[adjacentMines];
        }
    }
	
	// Update is called once per frame
	void Update () {
        isMine = Random.value < .05f;
	}
}
