using UnityEngine;

public class SemaforEnum : MonoBehaviour
{
    [SerializeField]
    GameObject redLight;

    [SerializeField]
    GameObject greenLight;

    [SerializeField]
    GameObject orangeLight;

    [SerializeField]
    float timeGreen = 15.0f;
    float timeOrange = 2.0f;
    float timeRed = 10.0f;
    float contador = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EncenderLuces(false, false, true);
    }

    void EncenderLuces(bool greenStatus, bool orangeStatus, bool redStatus)
    {
        redLight.SetActive(redStatus);
        greenLight.SetActive(greenStatus);
        orangeLight.SetActive(orangeStatus);
    }

    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;
        //PASAR A VERDE 
        if (contador > 10 && redLight.activeSelf == true)
        {
            EncenderLuces(true, false, false);
            contador = 0.0f;
        }
        //PASAR A AMBAR
        if (contador >= 15f && greenLight.activeSelf == true)
        {
            EncenderLuces(false, true, false);
            contador = 0.0f;
        }
        //PASA A ROJO
        if (contador >= 27 && orangeLight.activeSelf == true)
        {
            EncenderLuces(false, false, true);
            contador = 0.0f;
        }
    } 
}
