namespace Life
{
    class Program
    {
         interface Animal
        {
            //implementaqcion en el abtract animal los metodos para las clases de que usaran las herencias de animal
            void animalSound();
            void animalType();
            void animalAction();
            // No existen metodos generales en interface para cada herencia
            //void sleep();
            //void eat();
            
        }
        //implementacion de clases
        class dog : Animal
        {
             public  void animalType()
            {
                Console.WriteLine("Mamifero");
            }
             public  void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("wow wow");
            }
             public void animalAction()
            {
                Console.WriteLine("* correr");
            }

        }
        class cat : Animal
        {
            public  void animalType()
            {
                Console.WriteLine("Mamifero");
            }
            public  void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("meow meow");
            }
            public  void animalAction()
            {
                Console.WriteLine("* agazaparse");
            }
        }
        class capibara : Animal
        {
            public  void animalType()
            {
                Console.WriteLine("Mamifero");
            }
            public  void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine(" HAAAAAA HAAAAA");
            }
            public  void animalAction()
            {
                Console.WriteLine("* se sonroja");
            }
        }


        static void Main(string[] args)
        {
            //aplicacion de crear cualquier animal en base de las clases heredadas con sus metodos de "ANIMAL" y propios
            Console.WriteLine("DOG");
            dog dogi = new dog();
            dogi.animalType();
            dogi.animalSound();
            //dogi.sleep();
            dogi.animalAction();
            //dogi.eat();
            Console.WriteLine("CAT");
            cat cattt = new cat();
            cattt.animalType();
            cattt.animalSound();
            //cattt.sleep();
            cattt.animalAction();
            //cattt.eat();
            Console.WriteLine("Capibara");
            capibara capi = new capibara();
            capi.animalType();
            capi.animalSound();
            //capi.sleep();
            capi.animalAction();
            //capi.eat();

        }


    }
}