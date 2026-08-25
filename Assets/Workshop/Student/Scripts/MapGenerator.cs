using System;
using UnityEngine;

namespace Workshop.Student
{
    public class MapGenerator : MonoBehaviour
    {
        public int columns = 10;
        public int rows = 10;

        public GameObject[] floorTiles;
        public GameObject[] wallTiles;
        public GameObject[] foodTiles;

        public string[,] saveItemMap = new string[3, 3] {
            { " ", "Soda", " "},
            { " ", " ", " "},
            { " ", " ", "Food"},
        };

        // 1. declare Players variable
        public GameObject player;

        // 7. declare Exit variable 
        public GameObject exit;

        public void Start()
        {
            // 1. random player at the position <0, 0> map
            Instantiate(player, new Vector2(0, 0), Quaternion.identity);

            // 2. create obstacles 
            int midX = columns / 2;
            int halfHeight = rows / 2;

            for (int y = 0; y < halfHeight; y++)
            {
                int r = UnityEngine.Random.Range(0, wallTiles.Length);
                Instantiate(wallTiles[r], new Vector2(midX, y), Quaternion.identity);
            }

            // 3. create floor
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    int r = UnityEngine.Random.Range(0, floorTiles.Length);
                    GameObject tile = Instantiate(floorTiles[r], new Vector2(x, y), Quaternion.identity);
                    tile.name = "Floor" + x + "_" + y;


                    if (tile.GetComponent<SpriteRenderer>() != null)
                    {
                        tile.GetComponent<SpriteRenderer>().sortingOrder = -1;
                    }
                }
            }

            // 4. create walls
            for (int y = -1; y < rows + 1; y++)
            {
                for (int x = -1; x < columns + 1; x++)
                {
                    if (x == -1 || x == columns || y == -1 || y == rows)
                    {
                        int r = UnityEngine.Random.Range(0, wallTiles.Length);
                        GameObject tile = Instantiate(wallTiles[r], new Vector2(x, y), Quaternion.identity);
                        tile.name = "Wall" + x + "_" + y;
                    }
                }
            }

            // 5. random foods
            int numberofFoods = UnityEngine.Random.Range(1, 5);
            for (int i = 0; i < numberofFoods; i++)
            {
                int x_Food = UnityEngine.Random.Range(0, columns);
                int y_Food = UnityEngine.Random.Range(0, rows);
                int r = UnityEngine.Random.Range(0, foodTiles.Length);
                Instantiate(foodTiles[r], new Vector2(x_Food, y_Food), Quaternion.identity);
            }

            // 6. generate item along with the saveItemMap
            for (int y = 0; y < saveItemMap.GetLength(0); y++)
            {
                for (int x = 0; x < saveItemMap.GetLength(1); x++)
                {
                    string item = saveItemMap[y, x];
                    if (item != " ")
                    {
                        foreach (var Foodtile in foodTiles)
                        {
                            if (Foodtile.name == item)
                            {
                                GameObject food = Instantiate(Foodtile, new Vector2(x, y), Quaternion.identity);
                                food.name = item;
                                break;
                            }
                        }
                    }
                }
            }

            // 7. place exit
            Instantiate(exit, new Vector2(columns - 1, rows - 1), Quaternion.identity);
        }
    }
}