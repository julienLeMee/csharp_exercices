namespace TPCalculatrice
{
    public class Calculatrice
    {
        /// <summary>
        /// Cette méthode additionne deux nombres et renvoie le résultat
        /// </summary>
        /// <param name="nb1">Premier nombre</param>
        /// <param name="nb2">Deuxième nombre</param>
        /// <returns>Résultat de l'addition</returns>
        public int Addition(int nb1, int nb2)
        {
            return nb1 + nb2;
        }
        public int Soustraction(int nb1, int nb2)
        {
            return nb1 - nb2;
        }
        public int Multiplication(int nb1, int nb2)
        {
            return nb1 * nb2;
        }
        public int Division(int nb1, int nb2)
        {
            if (nb2 == 0)
            {
                return 0;
            }
            return nb1 / nb2;
        }
        public int Modulo(int nb1, int nb2)
        {
            return nb1 % nb2;
        }
    }
}
