using System;

public class Comment
{
    public string _commenter = "";
    public string _comment = "";

    public void DisplayComment()
    {
        Console.WriteLine(
            @$"
        {_commenter} 
        ({_comment}) 
        "
        );
    }
}
