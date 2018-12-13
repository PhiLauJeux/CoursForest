using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenererPlateformes : MonoBehaviour {

    public GameObject plateformeDepart;

    public GameObject plateforme1;
    public GameObject plateforme2;
    public GameObject plateforme3;
    public GameObject plateforme4;
    public GameObject plateforme5;
    public GameObject plateforme6;
    public GameObject plateforme7;

    public float vitesse;

    private GameObject blocChoisi;
    private GameObject plateforme;
    private GameObject plateformeAvant;

    // Use this for initialization
    void Start () {
        print("START");
        plateformeAvant = plateformeDepart;
        InvokeRepeating("ChoixBloc", 0, vitesse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ChoixBloc()
    {
        print("ChoixBloc");
        var bloc = Random.Range(1, 8);

        switch (bloc)
        {
            case 1:
            default:
                blocChoisi = plateforme1;
                break;
            case 2:
                blocChoisi = plateforme2;
                break;
            case 3:
                blocChoisi = plateforme3;
                break;
            case 4:
                blocChoisi = plateforme4;
                break;
            case 5:
                blocChoisi = plateforme5;
                break;
            case 6:
                blocChoisi = plateforme6;
                break;
            case 7:
                blocChoisi = plateforme7;
                break;
        }

        ChoixDispo(blocChoisi);
    }

    void ChoixDispo(GameObject bloc)
    {
        print("ChoixDispo");
        var dispo = Random.Range(1, 13);

        switch (dispo)
        {
            case 1:
            default:
                Simple(bloc);
                break;
            case 2:
                Double(bloc);
                break;
            case 3:
                Triple(bloc);
                break;
            case 4:
                Pyramide(bloc);
                break;
            case 5:
                PyramideRenverse(bloc);
                break;
            case 6:
                UnDeux(bloc);
                break;
            case 7:
                DeuxUn(bloc);
                break;
            case 8:
                LettreJ(bloc);
                break;
            case 9:
                LettreL(bloc);
                break;
            case 10:
                DiagonalDroite(bloc);
                break;
            case 11:
                DiagonaleGauche(bloc);
                break;
            case 12:
                Trou(bloc);
                break;
        }
    }

    //1ere Disposition
    void Simple(GameObject bloc)
    {
        float posX = Random.Range(plateformeAvant.transform.position.x + 2, plateformeAvant.transform.position.x + 5);
        float posY = Random.Range(plateformeAvant.transform.position.y - 3, plateformeAvant.transform.position.y + 3);

        if (posY < -4.3)
        {
            posY = -4.3f;
        }
        else if(posY > 5.42)
        {
            posY = 5.42f;
        }

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(posX, posY);

        plateformeAvant = plateforme;
    }

    //2eme Disposition
    void Double(GameObject bloc)
    {
        float posX = Random.Range(plateformeAvant.transform.position.x + 2, plateformeAvant.transform.position.x + 5);
        float posY = Random.Range(plateformeAvant.transform.position.y - 3, plateformeAvant.transform.position.y + 3);

        if (posY < -4.3)
        {
            posY = -4.3f;
        }
        else if (posY > 5.42)
        {
            posY = 5.42f;
        }

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(posX, posY);

        plateformeAvant = plateforme;


        plateforme = Instantiate(bloc);

        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y);

        plateformeAvant = plateforme;
    }

    //3eme Disposition
    void Triple(GameObject bloc)
    {
        float posX = Random.Range(plateformeAvant.transform.position.x + 2, plateformeAvant.transform.position.x + 5);
        float posY = Random.Range(plateformeAvant.transform.position.y - 3, plateformeAvant.transform.position.y + 3);

        if (posY < -4.3)
        {
            posY = -4.3f;
        }
        else if (posY > 5.42)
        {
            posY = 5.42f;
        }

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(posX, posY);

        plateformeAvant = plateforme;

        for (int i = 0; i < 2; i++)
        {
            plateforme = Instantiate(bloc);

            plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y);

            plateformeAvant = plateforme;
        }
    }

    //4eme Disposition
    void Pyramide(GameObject bloc)
    {
        float posX = Random.Range(plateformeAvant.transform.position.x + 2, plateformeAvant.transform.position.x + 5);
        float posY = Random.Range(plateformeAvant.transform.position.y - 3, plateformeAvant.transform.position.y + 3);

        if (posY < -4.3)
        {
            posY = -4.3f;
        }
        else if (posY > 5.42)
        {
            posY = 5.42f;
        }

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(posX, posY);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y + plateforme.GetComponent<Renderer>().bounds.size.y);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y - plateforme.GetComponent<Renderer>().bounds.size.y);
        plateformeAvant = plateforme;
    }

    //5eme Disposition
    void PyramideRenverse(GameObject bloc)
    {
        float posX = Random.Range(plateformeAvant.transform.position.x + 2, plateformeAvant.transform.position.x + 5);
        float posY = Random.Range(plateformeAvant.transform.position.y - 3, plateformeAvant.transform.position.y + 3);

        if (posY < -4.3)
        {
            posY = -4.3f;
        }
        else if (posY > 5.42)
        {
            posY = 5.42f;
        }

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(posX, posY);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y - plateforme.GetComponent<Renderer>().bounds.size.y);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y + plateforme.GetComponent<Renderer>().bounds.size.y);
        plateformeAvant = plateforme;
    }

    //6eme Disposition
    void UnDeux(GameObject bloc)
    {
        float posX = Random.Range(plateformeAvant.transform.position.x + 2, plateformeAvant.transform.position.x + 5);
        float posY = Random.Range(plateformeAvant.transform.position.y - 3, plateformeAvant.transform.position.y + 3);

        if (posY < -4.3)
        {
            posY = -4.3f;
        }
        else if (posY > 5.42)
        {
            posY = 5.42f;
        }

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(posX, posY);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y - plateforme.GetComponent<Renderer>().bounds.size.y);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y);
        plateformeAvant = plateforme;
    }

    //7eme Disposition
    void DeuxUn(GameObject bloc)
    {
        float posX = Random.Range(plateformeAvant.transform.position.x + 2, plateformeAvant.transform.position.x + 5);
        float posY = Random.Range(plateformeAvant.transform.position.y - 3, plateformeAvant.transform.position.y + 3);

        if (posY < -4.3)
        {
            posY = -4.3f;
        }
        else if (posY > 5.42)
        {
            posY = 5.42f;
        }

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(posX, posY);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y + plateforme.GetComponent<Renderer>().bounds.size.y);
        plateformeAvant = plateforme;
    }

    //8eme Disposition
    void LettreJ(GameObject bloc)
    {
        float posX = Random.Range(plateformeAvant.transform.position.x + 2, plateformeAvant.transform.position.x + 5);
        float posY = Random.Range(plateformeAvant.transform.position.y - 3, plateformeAvant.transform.position.y + 3);

        if (posY < -4.3)
        {
            posY = -4.3f;
        }
        else if (posY > 5.42)
        {
            posY = 5.42f;
        }

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(posX, posY);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y + plateforme.GetComponent<Renderer>().bounds.size.y);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x, plateformeAvant.transform.position.y + plateforme.GetComponent<Renderer>().bounds.size.y);
        plateformeAvant = plateforme;
    }

    //9eme Disposition
    void LettreL(GameObject bloc)
    {
        float posX = Random.Range(plateformeAvant.transform.position.x + 2, plateformeAvant.transform.position.x + 5);
        float posY = Random.Range(plateformeAvant.transform.position.y - 3, plateformeAvant.transform.position.y + 3);

        if (posY < -4.3)
        {
            posY = -4.3f;
        }
        else if (posY > 5.42)
        {
            posY = 5.42f;
        }

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(posX, posY);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x, plateformeAvant.transform.position.y - plateforme.GetComponent<Renderer>().bounds.size.y);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y - plateforme.GetComponent<Renderer>().bounds.size.y);
        plateformeAvant = plateforme;
    }

    //10eme Disposition
    void DiagonalDroite(GameObject bloc)
    {
        float posX = Random.Range(plateformeAvant.transform.position.x + 2, plateformeAvant.transform.position.x + 5);
        float posY = Random.Range(plateformeAvant.transform.position.y - 3, plateformeAvant.transform.position.y + 3);

        if (posY < -4.3)
        {
            posY = -4.3f;
        }
        else if (posY > 5.42)
        {
            posY = 5.42f;
        }

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(posX, posY);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y + plateforme.GetComponent<Renderer>().bounds.size.y);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y + plateforme.GetComponent<Renderer>().bounds.size.y);
        plateformeAvant = plateforme;
    }

    //11eme Disposition
    void DiagonaleGauche(GameObject bloc)
    {
        float posX = Random.Range(plateformeAvant.transform.position.x + 2, plateformeAvant.transform.position.x + 5);
        float posY = Random.Range(plateformeAvant.transform.position.y - 3, plateformeAvant.transform.position.y + 3);

        if (posY < -4.3)
        {
            posY = -4.3f;
        }
        else if (posY > 5.42)
        {
            posY = 5.42f;
        }

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(posX, posY);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y - plateforme.GetComponent<Renderer>().bounds.size.y);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y - plateforme.GetComponent<Renderer>().bounds.size.y);
        plateformeAvant = plateforme;
    }

    //12eme Disposition
    void Trou(GameObject bloc)
    {
        float posX = Random.Range(plateformeAvant.transform.position.x + 2, plateformeAvant.transform.position.x + 5);
        float posY = Random.Range(plateformeAvant.transform.position.y - 3, plateformeAvant.transform.position.y + 3);

        if (posY < -4.3)
        {
            posY = -4.3f;
        }
        else if (posY > 5.42)
        {
            posY = 5.42f;
        }

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(posX, posY);
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y + (plateforme.GetComponent<Renderer>().bounds.size.y * 2));
        plateformeAvant = plateforme;

        plateforme = Instantiate(bloc);
        plateforme.transform.position = new Vector2(plateformeAvant.transform.position.x + plateforme.GetComponent<Renderer>().bounds.size.x, plateformeAvant.transform.position.y - (plateforme.GetComponent<Renderer>().bounds.size.y * 2));
        plateformeAvant = plateforme;
    }
}
