using System;
using System.Linq;
using UnityEngine;

public class ProblemaPractica2 : MonoBehaviour
{

    public string[] alumnos = {
        "ASTORGA SEPULVEDA CRISTIAN ALFREDO",
        "DIAZ REYNOSO LUIS GERARDO",
        "LANDA LUNA EDGAR MIGUEL",
        "LUEVANO CRUZ ARACELI",
        "MORALES ROSALES IVAN ALFREDO",
        "RODRIGUEZ CONTRERAS RAUL ARTURO",
        "TAPIA OLVERA JOSE LIAM",
        "BECERRA PERAZA ERICK ARTURO",
        "ESQUEDA GARCIA LUIS FERNANDO",
        "LAZCANO ORTIZ LUIS ELOY",
        "MARTINEZ SUAREZ SERGIO ALONSO",
        "QUINTERO CARRISOZA FELIX ABRAHAM",
        "ROSAS OCAMPO MIGUEL ANGEL",
        "ALVEZ MADRIGAL ABIMAEL",
        "CHAGALA JIMENEZ EDGAR ALBERTO",
        "HERNANDEZ CANO ISAAC",
        "LOPEZ MORENO NEREO CESAR",
        "MARTINEZ VILLANUEVA JORGE ANTONIO",
        "RAYGOZA DE LA PAZ BRANDON",
        "SANTOS MENDEZ DANIEL"
    };

    public string alumno = "DOMINGUEZ GONZALEZ PEDRO MARIO";

    void Start()
    {
        Array.Sort(alumnos);
        Debug.Log(estaInscrito(alumno, alumnos));
    }

    Boolean estaInscrito(string Alumno, string[] lista) {
        if(lista.Contains(Alumno)) {
            return true;
        }
        return false;
    }

}
