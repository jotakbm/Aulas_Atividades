using UnityEngine;
using static UnityEngine.GraphicsBuffer;

namespace BrasilRP
{
    public class Moto : MonoBehaviour
    {
        public float torque = 500;
        public float pesoVeiculo = 15000;
        public float direcao;
        public float soma;
        public float anguloGarfo;
        private float angulo;
        private float horizontal;

        public Transform[] MeshRodas;
        public WheelCollider[] ColisorRodas;
        public GameObject banco;
        public Transform garfo;
        private Rigidbody corpoRigido;

        private void Awake()
        {
            corpoRigido = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            corpoRigido.mass = pesoVeiculo;
        }

        private void Update()
        {
            GetKeys();
            SeAngles();
            SetPosition();
        }

        private void GetKeys()
        {
            if (Input.GetKey(KeyCode.D)) { horizontal = 1; }
            if (Input.GetKey(KeyCode.A)) { horizontal = -1; }
            if (Input.GetKeyUp(KeyCode.D)) { horizontal = 0; }
            if (Input.GetKeyUp(KeyCode.A)) { horizontal = 0; }
            direcao = horizontal;
        }

        private void SeAngles()
        {
            if (horizontal > 0.2f || horizontal < -0.2f)
            {
                angulo = Mathf.Lerp(angulo, direcao, Time.deltaTime * 4);
            }
            else
            {
                angulo = Mathf.Lerp(angulo, direcao, Time.deltaTime * 6);
            }

            ColisorRodas[0].steerAngle = angulo * (30 - soma);
        }

        private void SetPosition() 
        {
            for (int x = 0; x < ColisorRodas.Length; x++)
            {
                Quaternion quat;
                Vector3 pos;
                ColisorRodas[x].GetWorldPose(out pos, out quat);
                MeshRodas[x].position = pos;
                MeshRodas[x].rotation = quat;
            }
        }
    }
}