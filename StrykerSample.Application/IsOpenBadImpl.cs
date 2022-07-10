namespace StrykerSample.Application;

public class IsOpenBadImpl
{
    public bool IsOpen { get; set; }

    public IsOpenBadImpl(string isOpen)
    {
        if (isOpen == "true")
        {
            IsOpen = true;
            return;
        }

        if (isOpen == "false")
        {
            IsOpen = false;
        }

        IsOpen = false;
    }
}
