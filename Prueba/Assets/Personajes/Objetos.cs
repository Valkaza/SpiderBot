using UnityEngine;
using System.Collections;

public class Objetos : MonoBehaviour
{


    public static int llenar;

    public static bool estatua1;
    public static bool estatua2;
    public static bool estatua3;


    public Texture2D[] texturas;


    public GUITexture hudtextura;


    // Use this for initialization
    void Start()
    {
        llenar = 0;
        estatua1 = false;
        estatua2 = false;
        estatua2 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LlenarTextura()
    {
        llenar++;

        int posicion = 0;

        if (estatua1 && estatua2 && estatua3)
        {
            posicion = 7;
        }
        else if (estatua1 == true && estatua2 == false && estatua3 == false)
        {

            posicion = 1;
        }
        else if (estatua1 == false && estatua2 == true && estatua3 == false)
        {

            posicion = 2;
        }
        else if (estatua1 == true && estatua2 == false && estatua3 == true)
        {

            posicion = 3;
        }
        else if (estatua1 == true && estatua2 == true && estatua3 == false)
        {

            posicion = 4;
        }
        else if (estatua1 == true && estatua2 == false && estatua3 == true)
        {

            posicion = 5;
        }
        else if (estatua1 == false && estatua2 == true && estatua3 == true)
        {

            posicion = 6;
        }

        hudtextura.texture = texturas[posicion];


    }


    public void ValidarEstatua(int nEstatua)
    {

        switch (nEstatua)
        {
            case 1:
                estatua1 = true;
                break;
            case 2:
                estatua2 = true;
                break;
            case 3:
                estatua3 = true;
                break;
            default:
                estatua1 = true;
                estatua1 = true;
                estatua1 = true;
                break;
        }

    }

	public bool VerificarObjetos(){
		if (llenar >= 3) {
						return true;
			print("Tienes los 3 objetos");
				} else {
			print("Te faltan los 3 objetos");
			return false;		
		}

	}








}
