using UnityEngine;

// Atividade: Explique para que cada um dos metodos serve. Explique em que momento cada um destes deve ser usado, e por que usar um ao invés de outro. De tambem exemplos de quando usar isso.
// Coloque também os metodos em ordem de chamada, do primeiro a ser chamado até o ultimo para saber quem será chamado antes do outro.
// Agrupe também cada tipo de metodos em um "#region". Eles podem ser dos seguintes tipos: "Inicialização, Update, Finalização e Physics"
public class UnityCallbackOrderActivity : MonoBehaviour
{
    private void OnDestroy()
    {

    }

    private void LateUpdate()
    {

    }

    private void Awake()
    {
      
    }    
    
    private void OnCollisionExit(Collision collision)
    {
        
    }

    private void OnDisable()
    {

    }

    private void Start()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        
    }

    private void OnEnable()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void Update()
    {

    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }    
    
    private void FixedUpdate()
    {

    }
}