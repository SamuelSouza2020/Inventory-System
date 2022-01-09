using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Item
{
    public string id;
    public int quantidade;
    public Text txtQuant;
    public int iAttack;
    public int iLife;
    public int iRes;
    public int iPower;
    public int iShild;
    public int iIce;
    public Sprite iImage;
}
[System.Serializable]
public class LojaItem
{
    public string id;
    public int iValor;

}
