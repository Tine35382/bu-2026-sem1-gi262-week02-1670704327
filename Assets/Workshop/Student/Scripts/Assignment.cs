using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Assignment
{
    public class Assignment : MonoBehaviour
    {
        public void Start()
        {
            // สามารถนำ Comment (//) ออกเพื่อทดสอบโค้ดแต่ละข้อได้ครับ
            // AS01_RandomItemDrop();
            // AS02_NestedLoopForCreate2DMap();
            // AS03_NestedLoopForMakingWallAround();
            // AS04_AttackEnemy();
            // AS05_DynamicIterationLoop();
            // AS06_WhileLoopAndArray();
            // AS07_HealTargetAtIndex();
            // AS08_RandomPickingDialogue();
            // AS09_MultiplicationTable();
            // AS10_FindSummationFromZeroToNUsingWhileLoop();
            // AS11_SpawnEnemies();
            // StartCoroutine(AS12_CountTime());
            // AS13_SumOfNumbersInRow();
            // AS14_SumOfNumbersInColumn();
            // AS15_MakeTheTriangle();
            // AS16_MultiplicationTableOf_2_3_and_4();
            // EX_01_TicTacToeGame_TurnPlay();
        }

        #region Assignment

        [Header("AS01_RandomItemDrop")]
        public GameObject[] as01_items;
        public void AS01_RandomItemDrop()
        {
            if (as01_items == null || as01_items.Length == 0) return;

            int r = UnityEngine.Random.Range(0, as01_items.Length);
            GameObject go = Instantiate(as01_items[r]);
            Debug.Log($"Got item: {go.name}");
        }

        [Header("AS02_NestedLoopForCreate2DMap")]
        public GameObject[] as02_floorTiles;
        public int as02_columns = 5;
        public int as02_rows = 5;
        public void AS02_NestedLoopForCreate2DMap()
        {
            Debug.Log("Column ...\n" + as02_columns);
            Debug.Log("Row ...\n" + as02_rows);

            for (int y = as02_rows - 1; y >= 0; y--)
            {
                string rowStr = "";
                for (int x = 0; x < as02_columns; x++)
                {
                    int r = UnityEngine.Random.Range(0, as02_floorTiles.Length);
                    GameObject tile = Instantiate(as02_floorTiles[r], new Vector2(x, y), transform.rotation);
                    rowStr += tile.name;
                }
                Debug.Log(rowStr);
            }
        }

        [Header("AS03_NestedLoopForMakingWallAround")]
        public GameObject as03_wall;
        public int as03_columns = 5;
        public int as03_rows = 5;
        public void AS03_NestedLoopForMakingWallAround()
        {
            Debug.Log("Column ...\n" + as03_columns);
            Debug.Log("Row ...\n" + as03_rows);

            for (int y = as03_rows - 1; y >= 0; y--)
            {
                string rowStr = "";
                for (int x = 0; x < as03_columns; x++)
                {
                    if (x == 0 || x == as03_columns - 1 || y == 0 || y == as03_rows - 1)
                    {
                        Instantiate(as03_wall, new Vector2(x, y), transform.rotation);
                        rowStr += "*";
                    }
                    else
                    {
                        rowStr += " ";
                    }
                }
                Debug.Log(rowStr);
            }
        }

        [Header("AS04_AttackEnemy")]
        public int[] as04_enemyHP;
        public int as04_damage;
        public int as04_target;
        public void AS04_AttackEnemy()
        {
            if (as04_enemyHP == null || as04_enemyHP.Length == 0) return;


            as04_enemyHP[0] -= as04_damage;
            Debug.Log($"FirstEnemy hp :{as04_enemyHP[0]}");


            as04_enemyHP[as04_enemyHP.Length - 1] -= as04_damage;
            Debug.Log($"LastEnemy hp :{as04_enemyHP[as04_enemyHP.Length - 1]}");


            if (as04_target >= 0 && as04_target < as04_enemyHP.Length)
            {
                as04_enemyHP[as04_target] -= as04_damage;
                Debug.Log($"TargetEnemy {as04_target} hp :{as04_enemyHP[as04_target]}");
            }
        }

        [Header("AS05_DynamicIterationLoop")]
        public int as05_n;
        public void AS05_DynamicIterationLoop()
        {
            for (int i = 0; i < as05_n; i++)
            {
                Debug.Log(i);
            }
        }

        [Header("AS06_WhileLoopAndArray")]
        public string[] as06_ironManSuitNames;
        public void AS06_WhileLoopAndArray()
        {
            Debug.Log("======Log by One======");
            int i = 0;
            while (i < as06_ironManSuitNames.Length)
            {
                Debug.Log(as06_ironManSuitNames[i]);
                i += 1;
            }

            Debug.Log("======Log by Two======");
            i = 0;
            while (i < as06_ironManSuitNames.Length)
            {
                Debug.Log(as06_ironManSuitNames[i]);
                i += 2;
            }
        }

        [Header("AS07_HealTargetAtIndex")]
        public int[] as07_heroHPs;
        public int as07_heal;
        public int as07_targetIndex;
        public void AS07_HealTargetAtIndex()
        {
            if (as07_heroHPs == null || as07_heroHPs.Length == 0) return;

            as07_heroHPs[0] += as07_heal;
            Debug.Log($"FirstHero hp :{as07_heroHPs[0]}");

            as07_heroHPs[as07_heroHPs.Length - 1] += as07_heal;
            Debug.Log($"LastHero hp :{as07_heroHPs[as07_heroHPs.Length - 1]}");

            if (as07_targetIndex >= 0 && as07_targetIndex < as07_heroHPs.Length)
            {
                as07_heroHPs[as07_targetIndex] += as07_heal;
                Debug.Log($"TargetHero {as07_targetIndex} hp :{as07_heroHPs[as07_targetIndex]}");
            }
        }

        [Header("AS08_RandomPickingDialogue")]
        public string[] as08_dialogues;
        public void AS08_RandomPickingDialogue()
        {
            if (as08_dialogues == null || as08_dialogues.Length == 0) return;

            int r = UnityEngine.Random.Range(0, as08_dialogues.Length);
            Debug.Log(as08_dialogues[r]);
        }

        [Header("AS09_MultiplicationTable")]
        public int as09_n;
        public void AS09_MultiplicationTable()
        {
            for (int i = 1; i <= 12; i++)
            {
                Debug.Log($"{as09_n}x{i}={as09_n * i}");
            }
        }

        [Header("AS10_FindSummationFromZeroToNUsingWhileLoop")]
        public int as10_n;
        public void AS10_FindSummationFromZeroToNUsingWhileLoop()
        {
            int sum = 0;
            int i = 1;
            while (i <= as10_n)
            {
                sum += i;
                i++;
            }
            Debug.Log($"ผลรวมของ n จาก 1 ถึง {as10_n} คือ {sum}");
        }

        [Header("AS11_SpawnEnemies")]
        public int[] as11_enemyHPs;
        public GameObject as11_enemyPrefab;
        public void AS11_SpawnEnemies()
        {
            if (as11_enemyHPs == null) return;

            for (int i = 0; i < as11_enemyHPs.Length; i++)
            {

                Vector2 spawnPos = new Vector2(transform.position.x + i + 1, transform.position.y);
                GameObject enemy = Instantiate(as11_enemyPrefab, spawnPos, transform.rotation);


            }
        }

        [Header("AS12_CountTime")]
        public float as12_countTime;
        public IEnumerator AS12_CountTime()
        {
            float timer = as12_countTime;
            while (timer > 0)
            {
                Debug.Log($"Time left: {timer}");
                yield return new WaitForSeconds(1f);
                timer -= 1f;
            }
            Debug.Log("Time's up!");
        }

        [Header("AS13_SumOfNumbersInRow")]

        public Grid2DInt as13_matrix = new Grid2DInt
        {
            rows = 3,
            cols = 3,
            data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
        };
        public int as13_row;
        public void AS13_SumOfNumbersInRow()
        {
            var matrix = as13_matrix.Get2DArray();
            int sum = 0;


            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sum += matrix[as13_row, col];
            }
            Debug.Log($"Row ...\n{as13_row}\n{sum}");
        }

        [Header("AS14_SumOfNumbersInColumn")]
        public Grid2DInt as14_matrix = new Grid2DInt
        {
            rows = 3,
            cols = 3,
            data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
        };
        public int as14_column;
        public void AS14_SumOfNumbersInColumn()
        {
            var matrix = as14_matrix.Get2DArray();
            int sum = 0;


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sum += matrix[row, as14_column];
            }
            Debug.Log($"Col ...\n{as14_column}\n{sum}");
        }

        [Header("AS15_MakeTheTriangle")]
        public int as15_size;
        public void AS15_MakeTheTriangle()
        {
            Debug.Log($"Size ...\n{as15_size}");

            for (int i = 1; i <= as15_size; i++)
            {
                string rowStr = "";

                for (int j = 1; j <= i; j++)
                {
                    rowStr += "*";
                }
                Debug.Log(rowStr);
            }
        }

        [Header("AS16_MultiplicationTableOf_2_3_and_4")]
        public string as16_note = "MultiplicationTableOf 2 3 and 4";
        public void AS16_MultiplicationTableOf_2_3_and_4()
        {
            Debug.Log(as16_note);
            for (int i = 1; i <= 12; i++)
            {
                string line = $"2 x {i} = {2 * i}\t3 x {i} = {3 * i}\t4 x {i} = {4 * i}";
                Debug.Log(line);
            }
        }

        #endregion

        #region Extra assignment

        [Header("EX_01_TicTacToeGame_TurnPlay")]
        public Grid2DString ex01_board = new Grid2DString
        {
            rows = 3,
            cols = 3,
            data = new string[] {
                "X", "X", "O",
                "X", "O", "X",
                "", "", ""
            }
        };
        public string ex01_playerTurn = "O";
        public int ex01_row = 2;
        public int ex01_column = 0;
        public void EX_01_TicTacToeGame_TurnPlay()
        {
            var board = ex01_board.Get2DArray();


            if (ex01_row < 0 || ex01_row >= 3 || ex01_column < 0 || ex01_column >= 3 || !string.IsNullOrEmpty(board[ex01_row, ex01_column]))
            {
                PrintBoard(board);
                Debug.Log(">> Invalid move");
                return;
            }


            board[ex01_row, ex01_column] = ex01_playerTurn;


            PrintBoard(board);


            bool isWin = false;


            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == ex01_playerTurn && board[i, 1] == ex01_playerTurn && board[i, 2] == ex01_playerTurn) isWin = true;
                if (board[0, i] == ex01_playerTurn && board[1, i] == ex01_playerTurn && board[2, i] == ex01_playerTurn) isWin = true;
            }

            if (board[0, 0] == ex01_playerTurn && board[1, 1] == ex01_playerTurn && board[2, 2] == ex01_playerTurn) isWin = true;
            if (board[0, 2] == ex01_playerTurn && board[1, 1] == ex01_playerTurn && board[2, 0] == ex01_playerTurn) isWin = true;

            if (isWin)
            {
                Debug.Log($">> {ex01_playerTurn} Win!");
                return;
            }


            bool isDraw = true;
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (string.IsNullOrEmpty(board[r, c]))
                    {
                        isDraw = false;
                        break;
                    }
                }
            }

            if (isDraw)
            {
                Debug.Log(">> Draw");
            }
            else
            {
                Debug.Log(">> Continue");
            }
        }
        #endregion

        private void PrintBoard(string[,] board)
        {
            StringBuilder sb = new();
            for (int i = 0; i < 3; i++)
            {
                sb.AppendLine("-------------");
                sb.AppendLine("| " + spaceIfEmpty(board[i, 0]) + " | " + spaceIfEmpty(board[i, 1]) + " | " + spaceIfEmpty(board[i, 2]) + " |");
            }
            sb.AppendLine("-------------");
            Debug.Log(sb.ToString());
        }

        private string spaceIfEmpty(string value)
        {
            return string.IsNullOrEmpty(value) ? " " : value;
        }
    }


    [System.Serializable]
    public class Grid2DInt { public int rows; public int cols; public int[] data; public int[,] Get2DArray() { int[,] result = new int[rows, cols]; for (int i = 0; i < rows * cols; i++) result[i / cols, i % cols] = data[i]; return result; } }
    [System.Serializable]
    public class Grid2DString { public int rows; public int cols; public string[] data; public string[,] Get2DArray() { string[,] result = new string[rows, cols]; for (int i = 0; i < rows * cols; i++) result[i / cols, i % cols] = data[i]; return result; } }
}