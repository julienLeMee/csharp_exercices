namespace TPCalculatrice
{
    public class Calculatrice
    {
        public int Result { get; set; } // propriété
        public int OperandeGauche { get; set; }
        public int OperandeDroite { get; set; }

        /// <summary>
        /// Cette méthode additionne deux nombres et renseigne la propriété Result
        /// </summary>
        public void Addition() // méthode
        {
            Result = OperandeGauche + OperandeDroite;
        }
        public void Soustraction()
        {
            Result = OperandeGauche - OperandeDroite;
        }
        public void Multiplication()
        {
            Result = OperandeGauche * OperandeDroite;
        }
        public void Division()
        {
            if (OperandeDroite == 0)
            {
                Console.WriteLine("Erreur : Division par zéro.");
                Result = 0;
            }
            else
            {
                Result = OperandeGauche / OperandeDroite;
            }
        }
        public void Modulo()
        {
            Result = OperandeGauche % OperandeDroite;
        }
    }
}
