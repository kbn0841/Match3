using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    [SerializeField] private GameObject[] Items;

    //private TileItem[,] m_tileArray = new TileItem[6, 6];
    private Dictionary<string, TileItem> m_tileDic = new Dictionary<string, TileItem>();

    private GameObject m_tilePrefab = null;

    private int m_width = 6;
    private int m_height = 8;


	void Start ()
    {
        m_tilePrefab = Items[0];

        CreateTiles();
    }
	
    void CreateTiles()
    {
        for(int i = 0; i < m_height; i++)
        {
            for(int j = 0; j < m_width; j++)
            {
                string key = j.ToString() + "," + i.ToString();

                TileItem tile = Instantiate<TileItem>(m_tilePrefab.transform.GetComponent<TileItem>());

                tile.transform.SetParent(this.transform);
                tile.transform.localPosition = new Vector3(j, i, 0.0f);
                //Debug.Log("[" + j + ", " + i + "] : " + tile.transform.position);
                m_tileDic.Add(key, tile);
            }
        }
    }
}
