namespace EXERCÍCIOALUNOS;
class Alunos
{
    public string nome="";
    public double nota1,nota2;

    //MEDIA -> retorna um double(por exemplo como um numero 8.3)
    public double obterMedia(){
        double media = (nota1+nota2)/2;
        return media;
    }
    //SITUAÇÃO -> retorna uma string ("Aprovado" ou "Reprovado")
    public string obterSituacao(double media){
        string situacao="";
        if(media>=6){
            situacao="Aprovado";
         }else{
            situacao="Reprovado";
         }
         return situacao;
        }
    
    //MENSAGEM -> não retorna nada. Só mostra na tela os detalhes (nome ,media e situação)

    public void mensagem(){
        double MediaCalculada = obterMedia();
        string resultadoSituacao = obterSituacao(MediaCalculada);
        Console.WriteLine(nome+" está " +resultadoSituacao+" com média:6" + MediaCalculada);
    
   } 

   }