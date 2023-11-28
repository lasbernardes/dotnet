// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region academy

Treinador tre=new Treinador();

tre.Nome="Joao";
tre.CPF="123";
tre.Nascimento="21/10/1987";

tre.printNome();

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
        Console.WriteLine($"{CREF}");
    }

   



}

public class Cliente:Pessoa{
    private float _altura{get;set;}
    private float _peso{get;set;}

    public float Altura{ 
        
        get{return _altura;}
    
        set{
            if(value <= 0){
                throw new ArgumentException("Altura não pode ser negativa!");
            }else{
                _altura=value;
            }
            
        }
    
    }
    public float Peso{ 
        
        get{return _peso;}
    
        set{
            if(value <= 0){
                throw new ArgumentException("Peso não pode ser negativa!");
            }else{
                _peso=value;
            }
            
        }
    
    }
}

#endregion