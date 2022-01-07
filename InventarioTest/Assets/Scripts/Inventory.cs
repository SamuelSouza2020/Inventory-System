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
        //mouseItem.SetActive(false);

        //Verificar o objeto consumido e subtrair
        for(int a = 0; a < 6; a++)
        {
            if(item[a].id == mouseItem.name)
            {
                Debug.Log(mouseItem.name);
                item[a].quantidade--;
                break;
            }
        }
    }
}
