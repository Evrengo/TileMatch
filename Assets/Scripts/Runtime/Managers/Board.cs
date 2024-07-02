using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [Header("Project Dependency")]
    [SerializeField] Tile tilePrefab;

    [Header("Scene Dependency")]
    [SerializeField] Transform tileParent;

    private void Awake()
    {
        TouchEvents.OnElementTapped += TileTapped;
        PrepareTiles();
    }

    private void OnDestroy()
    {
        TouchEvents.OnElementTapped -= TileTapped;
    }

    public Tile[] Tiles { get; private set; }

    void PrepareTiles()
    {
        var tileCount = 5;
        Tiles = new Tile[tileCount];//todo: change with level tile amount

        for (int i = 0; i < tileCount; i++) 
        {
            Tiles[i]=Instantiate(tilePrefab, tileParent);
        }
    }

    void TileTapped(ITouchable touchable)
    {
        var tappedTile =touchable.gameObject.GetComponent<Tile>();
    }
}
