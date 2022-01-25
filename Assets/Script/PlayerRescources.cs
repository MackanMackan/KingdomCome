using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRescources : MonoBehaviour
{
    public static int stone;
    public static int wood;
    public static int gold;

    int oldWood = 0;
    int oldStone = 0;
    int oldGold = 0;

    public TMPro.TextMeshProUGUI woodText;
    public TMPro.TextMeshProUGUI stoneText;
    public TMPro.TextMeshProUGUI goldText;
    void Start()
    {
        wood = 0;
        oldWood = 0;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateResources();
    }
    void UpdateWood()
    {
        if(wood > oldWood)
        {
            woodText.text = "Wood: " + wood;
            oldWood = wood;
        }
    }

    public void AddGold()
    {
        gold++;
    }

    void UpdateStone()
    {
        if (stone > oldStone)
        {
            stoneText.text = "Stone: " + stone;
            oldStone = stone;
        }
    }
    void UpdateGold()
    {
        if (gold > oldGold)
        {
            goldText.text = "Gold: " + gold;
            oldGold = gold;
        }
    }
    public void AddWood()
    {
        wood++;
    }
    public void AddStone()
    {
        stone++;
    }
    void UpdateResources()
    {
        UpdateWood();
        UpdateStone();
        UpdateGold();
    }
}
