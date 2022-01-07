using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public Item[] item;

    public GameObject mouseItem;


    public void DragItem(GameObject button)
    {
        mouseItem = button;
        mouseItem.transform.position = Input.mousePosition;
    }
    public void ClickItem(GameObject button)
    {
        mouseItem = button;
    }
    public void DropItem(GameObject button)
    {
        if(mouseItem != null)
        {
            //usar a variavel auxiliar para trocar os botoes
            Transform aux = mouseItem.transform.parent;

            mouseItem.transform.SetParent(button.transform.parent);
            button.transform.SetParent(aux);
        }
    }
    public void ConsumeItem()
    {
        if(UIManager.instance.pyMoney > 0)
        {
            //Verificar o objeto consumido e subtrair
            for (int a = 0; a < 6; a++)
            {
                if (item[a].id == mouseItem.name)
                {
                    Debug.Log(mouseItem.name);
                    item[a].quantidade--;
                    UIManager.instance.pyMoney--;
                    UIManager.instance.pyLife += item[a].iLife;
                    UIManager.instance.pyPower += item[a].iPower;
                    UIManager.instance.pyMoney += item[a].iGold;
                    UIManager.instance.pyShild += item[a].iShild;
                    if (item[a].quantidade < 1)
                    {
                        mouseItem.SetActive(false);
                    }
                    break;
                }
            }
        }
    }
}
