using UnityEngine;

public class SemaforoEnum : MonoBehaviour
{
   public enum EstadoEnumSemaforo
    {
        enRojo,
        enVerde,
        enAmarillo
    }

    [SerializeField]
    EstadoEnumSemaforo estadoSemaforo = EstadoEnumSemaforo.enRojo;

    float timer = 0.0f;

    // Update is called once per frame
    void Update()
    {
      switch (estadoSemaforo)
        {
            case EstadoEnumSemaforo.enRojo:
                EjecutarSemaforoRojo();
                break;
        }
    }
    void EjecutarSemaforoRojo()
    {
        if (timer > 10.0f)
        {
            //PONER LUZ VERDE
            estadoSemaforo = EstadoEnumSemaforo.enVerde;
        }
    }




}
