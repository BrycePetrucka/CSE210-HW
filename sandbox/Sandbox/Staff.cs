public class Staff
{
    private string _firstName;
    private string _lastName;
    private string _gender;

    public Staff(string firstName, string lastName, string gender)
    {
        _firstName = firstName;
        _lastName = lastName;
        _gender = gender;
    }

    public string GetLastName()
    {
        return _lastName;
    }

    public string GetGender()
    {
        return _gender;
    }

}