namespace StrykerSample.Application;

public class IsOpenGoodImpl
{
    public bool IsOpen { get; set; }

    public IsOpenGoodImpl(string isOpen)
    {
        IsOpen = isOpen == "true";
    }
}