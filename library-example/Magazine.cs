public class Magazine : Loanable
{
    private int _issueNo;
    private string _title;

    public void Magazine(int issueNo, string title)
    {
        _issueNo = issueNo;
        _title = title;
    }
}