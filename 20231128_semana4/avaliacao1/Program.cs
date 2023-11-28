// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region academy


var ListaTre=new List<Treinador>();
var tre1=new Treinador{
    Nome = "Joao",
    Nascimento = DateTime.Parse("21/10/1987"),
    CPF = "123",
    CREF = "A111"
    };
ListaTre.Add(tre1);
var tre2=new Treinador{
    Nome = "Jose",
    Nascimento = DateTime.Parse("21/10/1986"),
    CPF = "124",
    CREF = "A112"
    };
ListaTre.Add(tre2);
var tre3=new Treinador{
    Nome = "Maria",
    Nascimento = DateTime.Parse("21/10/1988"),
    CPF = "125",
    CREF = "A113"
    };
ListaTre.Add(tre3);
 var SubListTreIdade = ListaTre.Where(i => ( i.Nascimento >= DateTime.Parse("21/10/1986") && 
                                    i.Nascimento <= DateTime.Parse("21/10/1988")));

SubListTreIdade.ElementAt(0).print();

Console.WriteLine("--------------------------");
ListaTre.ElementAt(0).print();
ListaTre.ElementAt(1).print();
ListaTre.ElementAt(2).print();
Console.WriteLine("--------------------------");
//----------------------fim treinador---------------
//------------------inicio cliente---------------
var ListaCli=new List<Cliente>();
var cli1=new Cliente{
    Nome = "CliJoao",
    Nascimento = DateTime.Parse("21/10/1997"),
    CPF = "cli123",
    Altura = 1.45,
    Peso= 65
    };
ListaCli.Add(cli1);

ListaCli.ElementAt(0).print();
//-----------------fim cliente------------------



public class Pessoa{

    protected string _nome{get;set;}
    protected DateTime _nascimento {get;set;}

    protected string _cpf {get;set;}

   public string Nome{ 
        
        get{return _nome;}
    
        set{
            if(value == ""){
                throw new ArgumentException("Nome não pode ser vazio!");
            }else{
                _nome=value;
            }
            
        }
    
    }

    public DateTime Nascimento{ 
        
        get{return _nascimento;}
    
        set{
            //if(value == ""){
              //  throw new ArgumentException("Nascimento não pode ser vazio!");
            //}else{
                _nascimento=value;
            //}
            
        }
    }
    public string CPF{ 
        
        get{return _cpf;}
    
        set{
            if(value == ""){
                throw new ArgumentException("Nome não pode ser vazio!");
            }else{
                _cpf=value;
            }
            
        }
    
    }

    public virtual void print(){
        Console.WriteLine($"{Nome}");
        Console.WriteLine($"{Nascimento}");
        Console.WriteLine($"{CPF}");
    }

}

public class Treinador : Pessoa{
    private string _cref{get;set;}

    public string CREF{ 
        
        get{return _cref;}
    
        set{
            if(value == ""){
                throw new ArgumentException("CREF não pode ser vazio!");
            }else{
                _cref=value;
            }
            
        }
    
    }
    
    public override void print(){
        base.print();
        Console.WriteLine($"{CREF}");
    }

    //public List<Treinador> RangeIdade(var data = (from item in collection
      //          select item).Distinct()){


    //}
   



}

public class Cliente:Pessoa{
    private double _altura{get;set;}
    private double _peso{get;set;}

    public double Altura{ 
        
        get{return _altura;}
    
        set{
            if(value <= 0){
                throw new ArgumentException("Altura não pode ser negativa!");
            }else{
                _altura=value;
            }
            
        }
    
    }
    public double Peso{ 
        
        get{return _peso;}
    
        set{
            if(value <= 0){
                throw new ArgumentException("Peso não pode ser negativa!");
            }else{
                _peso=value;
            }
            
        }
    
    }
    public override void print(){
        base.print();
        Console.WriteLine($"{Altura}");
        Console.WriteLine($"{Peso}");

    }
}

#endregion