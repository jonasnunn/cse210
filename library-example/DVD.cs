public class DVD : Loanable
{

    private string _title; 
    private string _director;


    public void Loanable(string title, string director)
    {
        _title = title;
        _director = director;
    }

}