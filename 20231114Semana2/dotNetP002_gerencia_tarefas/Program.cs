// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region gerenciador tarefas
class Program{
    static void Main(){
        var taskList = new List<List<String>>();
        //var itemsList;// = new List<String>();
        //List<List<string>> taskList = new List<List<string>>();

        var op=0;
        var itemsList = new List<String>();
        itemsList.Add( "tarefa1" );
        itemsList.Add( "tem de realizar1" );
        itemsList.Add( "21/11/2023" );
        itemsList.Add("0");

        taskList.Add(itemsList);

        itemsList = new List<String>();
        itemsList.Add( "tarefa2" );
        itemsList.Add( "tem de realizar2" );
        itemsList.Add( "22/11/2023" );
        itemsList.Add("0");

        taskList.Add(itemsList);

        itemsList = new List<String>();
        itemsList.Add( "tarefa3" );
        itemsList.Add( "tem de realizar3" );
        itemsList.Add( "20/11/2023" );
        itemsList.Add("0");

        taskList.Add(itemsList);

        //foreach(String item in taskList){
          //  System.Console.WriteLine($"tarefa: {item}");
        //}
        foreach(var list in taskList) {
            System.Console.WriteLine($">Tarefa: {list.ElementAt(0)}");
            System.Console.WriteLine($">Descri: {list.ElementAt(1)}");
            System.Console.WriteLine($">Data  : {list.ElementAt(2)}");
            System.Console.WriteLine($">termi : {list.ElementAt(3)}");


            //foreach(String item in list) {
            //    System.Console.WriteLine($"tarefa: {item}");
            //}
        }
       
        while(true){
            System.Console.WriteLine("Menu");
            System.Console.WriteLine("1- Inserir tarefa");
            System.Console.WriteLine("2- Listar tarefas");
            System.Console.WriteLine("3- Marcar concluida");
            System.Console.WriteLine("4- Listar Pendentes e Concluidas");
            System.Console.WriteLine("5- Excluir tarefa");
            System.Console.WriteLine("6- Buscar por palavra chave");
            System.Console.WriteLine("7- Estatisticas");
            System.Console.WriteLine("0- Sair");

            System.Console.WriteLine("Digite opção:");
            op=int.Parse(System.Console.ReadLine());
            //System.Console.WriteLine($"{op}");
            switch (op){
                case 1:{
                    itemsList = new List<String>();
                    System.Console.WriteLine($"Insira uma tarefa:");
                    itemsList.Add(System.Console.ReadLine());
                    System.Console.WriteLine($"Insira uma descrição:");
                    itemsList.Add(System.Console.ReadLine());
                    System.Console.WriteLine($"Insira uma data de vencimento:");
                    itemsList.Add(System.Console.ReadLine());
                    itemsList.Add("0");
                    
                    taskList.Add(itemsList);
                    break;
                }
                case 2:{
                    foreach(var list in taskList) {
                        System.Console.WriteLine($"Tarefa     : {list.ElementAt(0)}");
                        System.Console.WriteLine($"Descrição  : {list.ElementAt(1)}");
                        System.Console.WriteLine($"Data       : {list.ElementAt(2)}");
                        System.Console.WriteLine($"terminado  : {list.ElementAt(3)}");

                    }
                   break;
                }
                case 3:{
                        System.Console.Write($"Digite idx da tarefa: ");
                        int idx = int.Parse(Console.ReadLine());
                        taskList[idx][3]="1";
                    break;
                }
                case 4:{
                    int i=0;
                    System.Console.WriteLine($"Concluídas: ");
                    foreach(var list in taskList) {
                        if(list[3]== "1"){
                            System.Console.WriteLine($"index: {i}");
                            System.Console.WriteLine($"Tarefa     : {list[0]}");
                            System.Console.WriteLine($"Descrição  : {list[1]}");
                            System.Console.WriteLine($"Data       : {list[2]}");
                            System.Console.WriteLine($"terminado  : {list[3]}");
                        }
                        i++;
                    }
                    System.Console.WriteLine($"-----------------------------------");
                    i=0;
                    System.Console.WriteLine($"Pendentes: ");
                    foreach(var list in taskList) {
                        if(list[3]== "0"){
                            System.Console.WriteLine($"index: {i}");
                            System.Console.WriteLine($"Tarefa     : {list[0]}");
                            System.Console.WriteLine($"Descrição  : {list[1]}");
                            System.Console.WriteLine($"Data       : {list[2]}");
                            System.Console.WriteLine($"terminado  : {list[3]}");
                        }
                        i++;
                    }
                    break;
                }
                case 5:{
                        System.Console.Write($"Digite idx da tarefa para remoção: ");
                        int idx = int.Parse(Console.ReadLine());
                        taskList.RemoveAt(idx);

                    break;
                }
                case 6:{
                    int i=0;
                    System.Console.Write($"Digite palavra a ser buscada: ");
                    string aux=System.Console.ReadLine();
                    foreach(var list in taskList) {
                        if(list[0].Contains(aux)||list[1].Contains(aux)||list[2].Contains(aux)||list[3].Contains(aux)){
                            System.Console.WriteLine($"index: {i}");
                            System.Console.WriteLine($"Tarefa     : {list[0]}");
                            System.Console.WriteLine($"Descrição  : {list[1]}");
                            System.Console.WriteLine($"Data       : {list[2]}");
                            System.Console.WriteLine($"terminado  : {list[3]}");
                        }
                        i++;
                    }
                    break;
                }
                case 7:{
                     var objetosEmOrdem = (from o in taskList
                          orderby o[2]
                           select o).ToList();
                          //select s);
                          System.Console.WriteLine($"Tarefa mais antiga: ");
                          System.Console.WriteLine($"{objetosEmOrdem[0][0]}");
                          System.Console.WriteLine($"{objetosEmOrdem[0][1]}");
                          System.Console.WriteLine($"{objetosEmOrdem[0][2]}");
                          System.Console.WriteLine($"{objetosEmOrdem[0][3]}");

                          System.Console.WriteLine($"Tarefa mais recente: ");
                          System.Console.WriteLine($"{objetosEmOrdem[objetosEmOrdem.Count-1][0]}");
                          System.Console.WriteLine($"{objetosEmOrdem[objetosEmOrdem.Count-1][1]}");
                          System.Console.WriteLine($"{objetosEmOrdem[objetosEmOrdem.Count-1][2]}");
                          System.Console.WriteLine($"{objetosEmOrdem[objetosEmOrdem.Count-1][3]}");
                          System.Console.WriteLine($"-------------------------");


                    int i=0;
                    //System.Console.WriteLine($"Concluídas: ");
                    foreach(var list in taskList) {
                        if(list[3]== "1"){
                            System.Console.WriteLine($">>index: {i}");
                            System.Console.WriteLine($">>Tarefa     : {list[0]}");
                            System.Console.WriteLine($">>Descrição  : {list[1]}");
                            System.Console.WriteLine($">>Data       : {list[2]}");
                            System.Console.WriteLine($">>terminado  : {list[3]}");
                            i++;
                        }
                        
                    }
                    System.Console.WriteLine($"Tarefas concluidas: {i}");
                    System.Console.WriteLine($"Tarefas pendentes : {Math.Abs(taskList.Count - i)}");
                    System.Console.WriteLine($"Tarefas total     : {(taskList.Count)}");
                    System.Console.WriteLine($"-----------------------------------");
                   
                    break;
                }
                case 0:{
                    System.Console.WriteLine($"opção sair");
                    return;
                    break;
                }
                default:{
                    System.Console.WriteLine($"Opção invalida");
                    break;
                }
            }


        }
    }
}
#endregion