using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using TMPro;

public class Play_Cinematica : MonoBehaviour
{
    public GameObject parentObject; // The parent GameObject whose children you want to list.
    List<string> _Opciones = new List<string>();
    List<GameObject> _Cinematicas = new List<GameObject>();
    TMP_Dropdown m_Dropdown;

    // Start is called before the first frame update
    void Start()
    {
        PopulateChildNames();
        m_Dropdown = GetComponent<TMP_Dropdown>();
        m_Dropdown.ClearOptions();
        m_Dropdown.AddOptions(_Opciones);
        
    }

    public void EjecutaCuandoCambia(int val)
    {
        _Cinematicas[val].GetComponent<PlayableDirector>().Play();

    }

    void PopulateChildNames()
    {
        // Make sure the parentObject is not null.
        if (parentObject != null)
        {
            // Loop through each child of the parentObject.
            foreach (Transform hijo in parentObject.transform)
            {
                // Add the name of the child to the list. 
                _Opciones.Add(hijo.name);
                _Cinematicas.Add(hijo.gameObject);
            }

        }
        else
        {
            Debug.LogError("Parent Object in Dropdown Debug Panel is not assigned.");
        }
    }
}
