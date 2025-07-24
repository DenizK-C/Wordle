using System;
using UnityEngine;

public class TypeChecker : MonoBehaviour
{
    public Sprite[] letterTiles;
    public GameObject[] blankTiles;
    public GameObject[] blankRows;
    public string currentWord;
   
    public Sprite blanktile;
    public int maxletters = 5;
    public string guessWord = "BALLS";


    private int tilenum = 0;
    private int currentrow = 0;

    private void Start()
    {
        blankTiles[0] = blankRows[currentrow].transform.Find("Row1Blank1").gameObject;
        blankTiles[1] = blankRows[currentrow].transform.Find("Row1Blank2").gameObject;
        blankTiles[2] = blankRows[currentrow].transform.Find("Row1Blank3").gameObject;
        blankTiles[3] = blankRows[currentrow].transform.Find("Row1Blank4").gameObject;
    }

    private void changeRow(int guess)
    {
        switch (guess)
        {
            case 1:
                blankTiles[0] = blankRows[currentrow].transform.Find("Row2Blank1").gameObject;
                blankTiles[1] = blankRows[currentrow].transform.Find("Row2Blank2").gameObject;
                blankTiles[2] = blankRows[currentrow].transform.Find("Row2Blank3").gameObject;
                blankTiles[3] = blankRows[currentrow].transform.Find("Row2Blank4").gameObject;
                break;

            case 2:
                blankTiles[0] = blankRows[currentrow].transform.Find("Row3Blank1").gameObject;
                blankTiles[1] = blankRows[currentrow].transform.Find("Row3Blank2").gameObject;
                blankTiles[2] = blankRows[currentrow].transform.Find("Row3Blank3").gameObject;
                blankTiles[3] = blankRows[currentrow].transform.Find("Row3Blank4").gameObject;
                break;

            case 3:
                blankTiles[0] = blankRows[currentrow].transform.Find("Row4Blank1").gameObject;
                blankTiles[1] = blankRows[currentrow].transform.Find("Row4Blank2").gameObject;
                blankTiles[2] = blankRows[currentrow].transform.Find("Row4Blank3").gameObject;
                blankTiles[3] = blankRows[currentrow].transform.Find("Row4Blank4").gameObject;
                break;

            case 4:
                blankTiles[0] = blankRows[currentrow].transform.Find("Row5Blank1").gameObject;
                blankTiles[1] = blankRows[currentrow].transform.Find("Row5Blank2").gameObject;
                blankTiles[2] = blankRows[currentrow].transform.Find("Row5Blank3").gameObject;
                blankTiles[3] = blankRows[currentrow].transform.Find("Row5Blank4").gameObject;
                break;

            case 5:
                blankTiles[0] = blankRows[currentrow].transform.Find("Row6Blank1").gameObject;
                blankTiles[1] = blankRows[currentrow].transform.Find("Row6Blank2").gameObject;
                blankTiles[2] = blankRows[currentrow].transform.Find("Row6Blank3").gameObject;
                blankTiles[3] = blankRows[currentrow].transform.Find("Row6Blank4").gameObject;
                break;
        }
    }

    private void CheckLetter()
    {
        if (tilenum < 5 && tilenum >= 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[0];
                currentWord += "A";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[1];
                currentWord += "B";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[2];
                currentWord += "C";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[3];
                currentWord += "D";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[4];
                currentWord += "E";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[5];
                currentWord += "F";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.G))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[6];
                currentWord += "G";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[7];
                currentWord += "H";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.I))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[8];
                currentWord += "I";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.J))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[9];
                currentWord += "J";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[10];
                currentWord += "K";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[11];
                currentWord += "L";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.M))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[12];
                currentWord += "M";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.N))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[13];
                currentWord += "N";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.O))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[14];
                currentWord += "O";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[15];
                currentWord += "P";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[16];
                currentWord += "Q";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[17];
                currentWord += "R";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[18];
                currentWord += "S";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.T))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[19];
                currentWord += "T";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.U))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[20];
                currentWord += "U";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.V))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[21];
                currentWord += "V";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[22];
                currentWord += "W";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[23];
                currentWord += "X";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.Y))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[24];
                currentWord += "Y";
                tilenum++;
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = letterTiles[25];
                currentWord += "Z";
                tilenum++;
            }

        }

        if (tilenum <= 5 && tilenum > 0)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                tilenum--;
                currentWord = currentWord.Substring(0, currentWord.Length - 1);
                blankTiles[tilenum].GetComponent<SpriteRenderer>().sprite = blanktile;
            }
        }
    }

    private void Update()
    {
        CheckLetter();

        if (tilenum == 5)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                checkRight();
            }
        }
    }

    private void checkRight()
    {
        for (int i = 0; i < maxletters;)
        {
            //Check for greens
            if (currentWord[i] == guessWord[i])
            {
                blankTiles[i].GetComponent<SpriteRenderer>().color = Color.green;
            }
            //if not green check if yellow
            else
            {
                for (int j = 0; j < maxletters;)
                {
                    if (currentWord[i] == guessWord[j])
                    {
                        blankTiles[i].GetComponent<SpriteRenderer>().color = Color.yellow;
                    }
                    j++;
                }
            }
            i++;
        }
        if (currentWord == guessWord)
        {
            Debug.Log("Word is Right!");
        }
        else
        {
            Debug.Log("Switch to next column!");
        }
    }
}
