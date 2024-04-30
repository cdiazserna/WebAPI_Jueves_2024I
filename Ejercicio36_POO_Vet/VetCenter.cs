namespace Ejercicio36_POO_Vet
{
    public class VetCenter
    {
        public VetCenter()
        {

        }

        #region Methods
        public void ShowMenu()
        {
            //Declaración de variables locales
            int option;

            Console.WriteLine("-----------Bienvenido a Vet Center-----------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("-Seleccione una de las siguientes opciones: -");
            Console.WriteLine("-1. Comprar                                 -");
            Console.WriteLine("-2. Adoptar                                 -");
            Console.WriteLine("-3. Regalar                                 -");
            Console.WriteLine("---------------------------------------------");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1: //"Comprar una mascota"
                    BuyPet();
                    break;

                case 2: //"Adoptar una mascota"
                    AdoptPet();
                    break;

                case 3: //"Regalar una mascota"
                    GiveAwayPet();
                    break;
            }
        }

        private void BuyPet()
        {
            Console.WriteLine("------------Razas Disponibles-------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("-Seleccione una de las siguientes razas: -");
            Console.WriteLine("-1. Bulldog Francés / $1.500.000         -");
            Console.WriteLine("-2. Cocker Spaniel  / $500.000           -");
            Console.WriteLine("-3. Pointer Alemán  / $2.000.000         -");
            Console.WriteLine("-4. Husky           / $2.500.000         -");
            Console.WriteLine("-5. Perro Criollo   / $5.000 + El cuido  -");
            Console.WriteLine("------------------------------------------");
            int breedOption = Convert.ToInt32(Console.ReadLine());

            switch (breedOption)
            {
                case 1: 
                    Console.WriteLine("Felicitaciones, has comprado un Bulldog Francés por $1.500.000");
                    break;

                case 2:
                    Console.WriteLine("Felicitaciones, has comprado un Cocker Spaniel por $500.000");
                    break;

                case 3:
                    Console.WriteLine("Felicitaciones, has comprado un Pointer Alemán por $2.000.000");
                    break;

                case 4:
                    Console.WriteLine("Felicitaciones, has comprado un Husky por $2.500.000");
                    break;

                case 5:
                    Console.WriteLine("Felicitaciones, has comprado un Perro criollo por $5.000 y te obsequiaremos el cuido");
                    break;
            }
        }

        private void AdoptPet()
        {
            Console.Write("Ingrese la raza de la mascota que desea adoptar: ");
            string breed = Console.ReadLine();

            Console.WriteLine(String.Format("Gracias por adoptar un {0}.", breed));
        }

        private void GiveAwayPet()
        {
            Console.Write("Ingrese el nombre de la mascota: ");
            string name = Console.ReadLine();
            Console.Write("Ingrese la edad de la mascota: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la raza de la mascota: ");
            string breed = Console.ReadLine();
            Console.Write("Ingrese el peso de la mascota: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(String.Format("Gracias por regalar a {0}, de {1} años, de raza {2} y con un peso de {3} Kg.", name, age, breed, weight));
        }

        #endregion
    }
}
