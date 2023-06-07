using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
   public int gold;
   public TextMeshProUGUI goldText;

   public static GameManager instance;

   void Awake() {
    instance = this;
   }

   public void AddGold(int _gold) {
    gold += _gold;
    goldText.text = "Gold: " + gold;
   }

   public void TakeGold(int _gold) {
    gold -= _gold;
    goldText.text = "Gold: " + gold;
   }
}
