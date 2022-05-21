using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManipulacionCubos : MonoBehaviour
{
    public Text txtSeleccionado;
    int cubo;
    GameObject clone;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;    

    public void ActivarBtn1()
    {
        txtSeleccionado.text = "El Cubo 1 está activado";
        cubo = 1;
    }

    public void ActivarBtn2()
    {
        txtSeleccionado.text = "El Cubo 2 está activado";
        cubo = 2;
    }

    public void ActivarBtn3()
    {
        txtSeleccionado.text = "El Cubo 3 está activado";
        cubo = 3;
    }

    public void Instanciar()
    {
        switch (cubo)
        {
            case 1:
                clone = Instantiate(cube1);
                break;

            case 2:
                clone = Instantiate(cube2);
                break;

            case 3:
                clone = Instantiate(cube3);
                break;
        }

        destroy(clone, 2);
        clone.transform.position = new Vector3(0,1,0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
