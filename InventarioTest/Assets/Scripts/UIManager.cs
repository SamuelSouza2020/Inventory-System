using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //py = player
    public int pyLife, pyMoney, pyRes, pyPower, pyShild;
    [SerializeField]
    Text tLife, tMoney, tPower, tShild;
    public Button compra;

    public static UIManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        tLife = GameObject.Find("LifeP").GetComponent<Text>();
        tMoney = GameObject.Find("GoldP").GetComponent<Text>();
        tShild = GameObject.Find("ShildP").GetComponent<Text>();
        tPower = GameObject.Find("PowerP").GetComponent<Text>();

        compra = GameObject.Find("UsarItem").GetComponent<Button>();

        pyLife = 10;
        pyMoney = 5;
        pyPower = 10;
        pyShild = 10;
    }

    // Update is called once per frame
    void Update()
    {
        tLife.text = pyLife.ToString();
        tMoney.text = pyMoney.ToString();
        tShild.text = pyShild.ToString();
        tPower.text = pyPower.ToString();

        if(pyMoney <= 0)
        {
            UIManager.instance.compra.interactable = false;
        }
        else
        {
            UIManager.instance.compra.enabled = true;
        }
    }
}
