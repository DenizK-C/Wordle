using UnityEngine;

public class TypeChecker : MonoBehaviour
{
    public Sprite[] letterTiles;
    public GameObject[] blankTiles;
    public Sprite blanktile;
    public int tilenum = 0;
    public int maxletters = 5;

    private void Update()
    {
        if (tilenum < 5 && tilenum >= 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[0];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[1];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[2];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[3];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[4];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[5];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.G))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[6];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[7];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.I))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[8];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.J))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[9];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[10];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[11];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.M))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[12];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.N))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[13];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.O))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[14];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[15];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[16];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[17];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[18];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.T))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[19];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.U))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[20];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.V))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[21];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[22];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[23];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.Y))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[24];
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[25];
                tilenum++;
            }

        }

        if (tilenum <= 5 && tilenum > 0)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                tilenum--;
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = blanktile;
            }
        }
        
    }
}
