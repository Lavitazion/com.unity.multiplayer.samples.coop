using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Script_JC_Checkpoint : MonoBehaviour
{
    [Header("Variables:")]
    [SerializeField] private TimelineAsset cinematica; // Cinematica a reproducir. (Chequear si no es Null)
    [SerializeField] private bool pausa_gameplay;  // true = se desactiva el gameplay convencional // false = se reproduce cinematica pero los jugadores siguen en gameplay. 
    [SerializeField] private bool autosave_partida; // true = se guarda la partida en este punto.
    [SerializeField] private bool esRespawnPoint; // true = se guarda este punto como el último para respawnear.
    [Space(5)]
    [SerializeField] private GameObject objeto_bloqueo;
    [Space(5)]
    [SerializeField] private ZonasPjs zonasPjs;

    [System.Serializable] private class ZonasPjs
    {
        [SerializeField] private GameObject sofi;
        [SerializeField] private GameObject kael;
        [SerializeField] private GameObject kaine;
        [SerializeField] private GameObject sai;
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
