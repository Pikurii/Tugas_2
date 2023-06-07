using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int hp;
    public int hpMax;
    public int goldToGive;

    public Image hpImage;
    public Animation anim;

    public void Damage() {
        hp--;
        SetHpBar();

        anim.Stop();
        anim.Play();

        if (hp <= 0)Dead();
    }

    public void SetHpBar() {
        hpImage.fillAmount = (float)hp / (float)hpMax;
    }

    public void Dead(){
        GameManager.instance.AddGold(goldToGive);
        EnemyManager.instance.DestroyEnemy(gameObject);
    }
}
