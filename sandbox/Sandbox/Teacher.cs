public class Teacher : Staff
{
    private int _roomNumber;


    public Teacher(string firstName, string lastName, string gender, int roomNumber) : base(firstName, lastName, gender)
    {
        _roomNumber = roomNumber;
    }

    public string IntroMessage()
    {
        string lastName = GetLastName();
        string gender = GetGender();
        return $"Hello students, I am {gender} {lastName}. I teach in room {_roomNumber}.";
    }
}