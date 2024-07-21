
using Microsoft.VisualBasic;
using System.Globalization;

static void Notas() {

    static void Foreach () {
        Console.WriteLine("exemplo usando foreach em c#");
        Console.WriteLine("Estrutura foreach trabalha em cima de um array");
        int[] arInt = new int[] { 1, 2, 3, 4, 5 };
        foreach (int numero in arInt)
        {
            Console.WriteLine(numero);
        }
    }
    static void teste(float media)
       
    {
        Console.WriteLine("exenplo usando If, Switch e While em C#");
        Console.WriteLine("Checando Status de Aprovacao!");

        if (media <= 5)
        {
            Console.WriteLine("o aluno esta reprovado");
        }
        else if (media > 5 & media < 7)
        {
            Console.WriteLine("o aluno esta de recuperacao");
        }
        else
        {
            Console.WriteLine("o aluno passou");
        }


    }

    static void media()
    {
        Console.WriteLine("digite cade uma das suas 3 notas e aperte enter");
        int nota1 = Convert.ToInt32(Console.ReadLine());
        int nota2 = Convert.ToInt32(Console.ReadLine());
        int nota3 = Convert.ToInt32(Console.ReadLine());

        float media = (float)((nota1 + nota2 + nota3) / 3);
        Console.WriteLine($"sua media e:" + media);

        Console.WriteLine("Deseja verificar se esta aprovado?");
        string c = Console.ReadLine().ToUpper();
        if (c == "SIM")
        {
            teste(media);
        }
        else
        {
            Console.WriteLine("obrigado!");
        }
    }

    string flag = "ok";

    while (flag == "ok")
    {
        string msg = "______Notas_____\n" +
                 "-(0)--sair------\n" +
                 "-(1)--checkNota-\n" +
                 "-(2)--calcMedia-\n";

        Console.WriteLine(msg);
        Console.WriteLine("Digite o que deseja!");

        int a = Convert.ToInt32(Console.ReadLine());

        switch (a)
        {
            case 1:

                media();
                break;
            case 2:
                media();
                break;
            case 0:
                flag = "notok";
                break;
            default:
                flag = "notok";
                break;
        }

    }
}

static void ArrayseLisas()
{ 
    //um array se deve ser iniciado quando se sabe o tamanho estabelecido
    int[] numeros = new int[] { 1,2,3,4};
    Console.WriteLine(numeros[0]);
    //uma list pode ser iniciada sem taamanhi=o predefinido, melhor de trabalhar
    List<int> list = new List<int>();
    List<int> lst2 = new List<int>() { 1, 2, 3, 4 }; //se pode iniciar com valores tb
    //existe metodos de lista
    int count = list.Count;//conta numeros
    list.Add(8);//adiciona
    list.Remove(3);//remove
}

static void dict()
{
    Dictionary<int, string> estados = new Dictionary<int, string>();//incializados dict
    estados.Add(1,"RJ");
    estados.Add(2, "SP");
    estados.Add(3, "CE");
    estados.Add(4, "MA");
    estados.ContainsKey(4);//contem metodos tbm
    foreach(string estado in estados.Values)
    { 
    Console.WriteLine(estado); 
    }
    string est = estados[3];//a chave e o proprio indice
    Console.WriteLine(est);
}

string msg = "menu principal";
Console.WriteLine(msg);
dict();
console.WriteLine("teste");

