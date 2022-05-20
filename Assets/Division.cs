//Ejercicio 4 InputField

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Division : MonoBehaviour
{
    public Text numero1;
    public Text numero2;
    public GameObject resultado;
    public Text textoResultado;
    public GameObject cartelError;
    public Text textomsj;
    int num1;
    int num2;

    // Start is called before the first frame update
    void Start()
    {
        resultado.SetActive(false);
        cartelError.SetActive(false);
    }

    public void division()
    {
        if (numero1.text == "" || numero2.text == "")
        {
            cartelError.SetActive(true);
            textomsj.text = "Error: todos los campos deben ser completados.";
        }

        num1 = int.Parse(numero1.text);
        num2 = int.Parse(numero2.text);

        if (num2 == 0)
        {
            cartelError.SetActive(true);
            textomsj.text = "Error: el valor de num2 debe ser distinto de 0.";
        }

        else
        {
            resultado.SetActive(true);
            textoResultado.text = "El resultado es: " + (num1 / num2);
        }

    }
}
