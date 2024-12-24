namespace Balta.ContentContext
{
    public abstract class Content         //essa classe eu vou passar ela de herança para Article, Course e Career

    {          
        public Content()
        {
            Id = Guid.NewGuid();    //Gera um HASH pro Id // Ponto unico de falha
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}