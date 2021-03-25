using System;

namespace PcformandoPalvrasporNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Random pc_joga = new Random();
           
            int[] numerico = new int[5];
            int[] numerico2 = new int[5];
            int[] numerico3 = new int[5];
            char[] senha = new char[5];
            
            inicio:
            int confere = 0;
            Console.WriteLine("Crie uma senha de 5 digitos\nSENHA DEVE CONTER APENAS LETRAS E SER MAIUSCULA!");
            for (int i=0;i<senha.Length;i++)
            {
                senha[i] = Console.ReadKey().KeyChar;
            }
            Console.WriteLine("\nsua senha é :");
            Console.WriteLine(senha);

            Console.WriteLine("Agora tecle enter  para que o programa busque sua senha");
            Console.ReadKey();
            
                char[] alfanum = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 
                'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'W', 'Y', 'Z' };
            // Esta parte faz o bloqueio das letras que não são maiusculas.
            for (int i=0;i<senha.Length;i++)
            {
                for (int j=0;j<alfanum.Length;j++)
                {
                    if (senha[i] == alfanum[j])
                    {
                        confere += 1;
                        
                       
                    }
                }
               
            }
            if (confere != 5)
            {
                Console.Clear();
                goto inicio;
            }
            Console.ReadKey();
            double cont = 0;
            //--------------------------ira procurar a seha digitada:
            while (true)
            {
                cont += 1;

                for (int i = 0; i < numerico.Length; i++)
                {
                    numerico[i] = pc_joga.Next(0, 25);
                    numerico2[i] = pc_joga.Next(0,25);
                    numerico3[i] = pc_joga.Next(0,25);
                }

              Console.Write("{0}                   {1}{2}{3}{4}{5}             {6}{7}{8}{9}{10}              {11}{12}{13}{14}{15}", 
             cont, alfanum[numerico[0]], alfanum[numerico[1]], alfanum[numerico[2]], 
             alfanum[numerico[3]], alfanum[numerico[4]],alfanum[numerico2[0]], alfanum[numerico2[1]], alfanum[numerico2[2]],
             alfanum[numerico2[3]], alfanum[numerico2[4]], alfanum[numerico3[0]], alfanum[numerico3[1]], alfanum[numerico3[2]],
             alfanum[numerico3[3]], alfanum[numerico3[4]]);
                //acima mecânica de busca -----------------------
                Console.WriteLine();
                if (alfanum[numerico[0]] == senha[0] && alfanum[numerico[1]] == senha[1] && alfanum[numerico[2]] == senha[2]
                    && alfanum[numerico[3]] == senha[3] && alfanum[numerico[4]] == senha[4]) { Console.Beep(); Console.Beep(); Console.Beep();
                    Console.Beep(); Console.Write("Senha encontrada: em {0} tentativas\n\n",cont*3); break; }

                if (alfanum[numerico2[0]] == senha[0] && alfanum[numerico2[1]] == senha[1] && alfanum[numerico2[2]] == senha[2]
                  && alfanum[numerico2[3]] == senha[3] && alfanum[numerico2[4]] == senha[4])
                {
                    Console.Beep(); Console.Beep(); Console.Beep();
                    Console.Beep(); Console.Write("Senha encontrada: em {0} tentativas\n\n", cont*3); break;
                }
                if (alfanum[numerico3[0]] == senha[0] && alfanum[numerico3[1]] == senha[1] && alfanum[numerico3[2]] == senha[2]
                  && alfanum[numerico3[3]] == senha[3] && alfanum[numerico3[4]] == senha[4])
                {
                    Console.Beep(); Console.Beep(); Console.Beep();
                    Console.Beep(); Console.Write("Senha encontrada: em  {0} tentativas\n\n", cont*3); break;
                }


            }


            Console.ReadKey();    
               

            
        }
    }
}
