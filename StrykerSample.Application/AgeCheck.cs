namespace StrykerSample.Application;

public class AgeCheck
{
    const int LegalAge = 18;

    public static bool IsUserOldEnough(int age) => age >= LegalAge;


    // Comment out the above implementation and replace with below to see why the BadTests aren't covering all scenarios.
    /*public static bool IsUserOldEnough(int age)
    {
        if (age > LegalAge)
        {
            return true;
        }

        if (age == LegalAge)
        {
            return true;
        }

        return false;
    }*/
}
