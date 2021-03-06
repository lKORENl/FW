﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameProcess : MonoBehaviour
{
    public FillWordCreator creator;
    public GameObject CellGrid;

    public static List<List<int>> cellNumbers;
    public List<string> usedWords;
    int counter = 0;
    // Use this for initialization
    void Start()
    {
        usedWords = new List<string>();
        SetGameGread();


    }

    public void SetGameGread()   
    {
 
        CellGrid.GetComponent<GameFieldCreator>().CreateGameField();
        creator.ResetFillWord();
        FillTheCellsWithLetters();
        //DictionaryController.SavePasedDictionary();

     
        FillWordCreator.countOfResets = 0;
        CollorManager.MixListColor();
        this.gameObject.transform.GetComponent<CellController>().ResetCellsValue();
        //this.gameObject.transform.GetComponent<CellController>().SetColorForUsedWords();
      

    }
    public static void ShowCellNumbers()
    {
        string str = "";
        foreach (var x in cellNumbers)
        {
            foreach (var y in x)
            {
                str += y.ToString() + " ";
            }
            str += "\n";
        }
        Debug.Log(str);
    }

    void FillTheCellsWithLetters()
    {
        usedWords = new List<string>();
        usedWords.Clear();
        string str = "";
        for (int i = 0; i < cellNumbers.Count; i++)
        {
            str = DictionaryController.GetWordByTheNumberOfLetters(cellNumbers[i].Count, usedWords);
            if (str == null)
            {
                Debug.Log("Restart");
                SetGameGread();
                return;
            }

            usedWords.Add(str);

            int index = 0;
            int idWord = usedWords.IndexOf(str);
            for (int j = 0; j < cellNumbers[i].Count; j++)
            {
 
                CellGrid.transform.GetChild(cellNumbers[i][j]).transform.GetChild(0).GetComponent<Text>().text = str[index].ToString().ToUpper();
                index++;
            }
        }



    }
}
