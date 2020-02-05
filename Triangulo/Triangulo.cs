namespace Triangulo
{
    public class Triangulo
    {
        public int LadoA;
        public int LadoB;
        public int LadoC;

        public void VerificarTriangulo(){
            if ((LadoA < LadoB + LadoC) && (LadoB < LadoA + LadoC) && (LadoC < LadoB + LadoA))
            {
                System.Console.Write("Forma um Triângulo");
            } else {
                System.Console.Write("Não Forma um Triângulo");
            }
        }
    }
}