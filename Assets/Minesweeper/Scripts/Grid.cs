﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{

    public GameObject tilePrefab;
    public int width = 10, height = 10;
    public float spacing = .155f;

    private Tile[,] tiles;

    // Use this for initialization


    Tile SpawnTile(Vector3 pos)
    {
        GameObject clone = Instantiate(tilePrefab);
        clone.transform.position = pos;
        Tile currentTile = clone.GetComponent<Tile>();
        return currentTile;
    }


    void GenerateTiles() {
        tiles = new Tile[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int y =0; y < height; y++)
            {
                Vector2 halfSize = new Vector2(width * 0.5f,
                                                height * 0.5f);
                Vector2 pos = new Vector2(x - halfSize.x,
                                            y - halfSize.y);
                pos *= spacing;
                Tile tile = SpawnTile(pos);
                tile.transform.SetParent(transform);
                tile.x = x;
                tile.y = y;
                tiles[x, y] = tile;
            }
        }
    }


    void Start()
    {
        GenerateTiles();
    }


    // Update is called once per frame
    void Update()
    {

    }
}
